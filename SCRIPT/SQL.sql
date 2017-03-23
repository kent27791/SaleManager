CREATE VIEW vProduce
AS
SELECT p.ProduceId, p.ComputedId, p.Name, u.Name AS Unit, pg.Name AS ProduceGroup
FROM 
Produce AS p JOIN Unit AS u ON p.UnitId = u.UnitId
JOIN ProduceGroup AS pg ON p.ProduceGroupId = pg.ProduceGroupId

CREATE VIEW vReceipt
AS
SELECT r.ReceiptNoteId, r.ComputedId, r.[Date], s.Fullname AS Staff,  sl.Name AS Supplier, st.Name AS Stock, 
	   (SELECT COUNT(1) FROM ReceiptNote rr JOIN ReceiptNoteDetails rndd ON rr.ReceiptNoteId = rndd.ReceiptNoteId) AS Produces
FROM ReceiptNote r JOIN Staff s ON r.StaffId = s.StaffId
JOIN Supplier sl ON r.SupplierId = sl.SupplierId
JOIN Stock st ON r.StockId = r.StockId

CREATE VIEW vDelivery
AS
SELECT dn.DeliveryNoteId, dn.ComputedId, dn.[Date] ,st.Name AS Stock, s.Fullname AS Staff, ct.Fullname AS Customer,
	  (SELECT COUNT(1) FROM [DeliveryNote] dn JOIN DeliveryNoteDetails dnd ON dn.DeliveryNoteId = dnd.DeliveryNoteId) AS Produces
FROM [DeliveryNote] AS dn JOIN [Stock] AS st ON dn.StockId = st.StockId
JOIN [Staff] AS s ON dn.StaffId = s.StaffId
JOIN [Customer] AS ct ON dn.CustomerId = ct.CustomerId


SELECT * FROM vProduce
--Trigger affter insert on table Produce then insert to ProduceDeatils set default value.
CREATE TRIGGER trProduce 
ON [Produce]
AFTER INSERT
AS
BEGIN
	DECLARE @ProduceId INT
	SET @ProduceId = (SELECT ProduceId FROM inserted)
	INSERT INTO ProduceDetails([ProduceId],[Date],[OpeningStock],[ClosingStock],[InputStock],[OutputStock])
						VALUES(@ProduceId, GETDATE(), DEFAULT, DEFAULT, DEFAULT, DEFAULT)
END

CREATE TRIGGER trReceipt_Insert
ON [ReceiptNoteDetails]
AFTER INSERT
AS
BEGIN
	DECLARE @ProduceId INT
	DECLARE @InputStock INT
	SELECT @ProduceId = ProduceId FROM inserted
	SELECT @InputStock = SUM(Quantity) FROM ReceiptNoteDetails WHERE ProduceId = @ProduceId
	UPDATE [ProduceDetails] SET InputStock = @InputStock, [Date] = GETDATE() WHERE ProduceId = @ProduceId
END

ALTER TRIGGER trReceipt_Delete
ON [ReceiptNoteDetails]
AFTER DELETE
AS
BEGIN
	DECLARE @ProduceId INT
	DECLARE @InputStock INT
	SELECT @ProduceId = ProduceId FROM deleted
	SELECT @InputStock = SUM(Quantity) FROM ReceiptNoteDetails WHERE ProduceId = @ProduceId
	SET @InputStock = ISNULL(@InputStock, 0)
	UPDATE [ProduceDetails] SET InputStock = @InputStock, [Date] = GETDATE() WHERE ProduceId = @ProduceId
END

ALTER TRIGGER trReceipt_Update
ON [ReceiptNoteDetails]
AFTER UPDATE
AS
BEGIN
	DECLARE @ProduceId INT
	DECLARE @InputStock INT
	DECLARE @OldQuantity INT
	DECLARE @NewQuantity INT
	SELECT @ProduceId = ProduceId, @OldQuantity = Quantity FROM deleted
	SELECT @NewQuantity = Quantity FROM inserted
	SELECT @InputStock = SUM(Quantity) FROM ReceiptNoteDetails WHERE ProduceId = @ProduceId
	UPDATE [ProduceDetails] SET InputStock = @InputStock, [Date] = GETDATE() WHERE ProduceId = @ProduceId
END




SELECT * FROM ReceiptNote
SELECT * FROM ReceiptNoteDetails
SELECT * FROM Produce p JOIN ProduceDetails pp ON p.ProduceId = pp.ProduceId



ALTER TRIGGER trDelivery_Insert
ON [DeliveryNoteDetails]
AFTER INSERT
AS
BEGIN
	DECLARE @ProduceId INT
	DECLARE @OutStock INT
	SELECT @ProduceId = ProduceId FROM inserted
	SELECT @OutStock = SUM(Quantity) FROM DeliveryNoteDetails WHERE ProduceId = @ProduceId
	UPDATE [ProduceDetails] SET OutputStock = @OutStock, [Date] = GETDATE() WHERE ProduceId = @ProduceId
END

CREATE TRIGGER trDelivery_Delete
ON [DeliveryNoteDetails]
AFTER DELETE
AS
BEGIN
	DECLARE @ProduceId INT
	DECLARE @OutStock INT
	SELECT @ProduceId = ProduceId FROM deleted
	SELECT @OutStock = SUM(Quantity) FROM DeliveryNoteDetails WHERE ProduceId = @ProduceId
	SET @OutStock = ISNULL(@OutStock, 0)
	UPDATE [ProduceDetails] SET OutputStock = @OutStock, [Date] = GETDATE() WHERE ProduceId = @ProduceId
END

CREATE TRIGGER trDelivery_Update
ON [DeliveryNoteDetails]
AFTER UPDATE
AS
BEGIN
	DECLARE @ProduceId INT
	DECLARE @OutputStock INT
	DECLARE @OldQuantity INT
	DECLARE @NewQuantity INT
	SELECT @ProduceId = ProduceId, @OldQuantity = Quantity FROM deleted
	SELECT @NewQuantity = Quantity FROM inserted
	SELECT @OutputStock = SUM(Quantity) FROM DeliveryNoteDetails WHERE ProduceId = @ProduceId
	UPDATE [ProduceDetails] SET OutputStock = @OutputStock, [Date] = GETDATE() WHERE ProduceId = @ProduceId
END


SELECT * FROM DeliveryNote
SELECT * FROM DeliveryNoteDetails
SELECT * FROM Produce p JOIN ProduceDetails pp ON p.ProduceId = pp.ProduceId

SELECT * FROM ReceiptNote
SELECT * FROM ReceiptNoteDetails
SELECT * FROM Produce p JOIN ProduceDetails pp ON p.ProduceId = pp.ProduceId

CREATE VIEW vInventory
AS
SELECT p.ProduceId, p.ComputedId, p.Name, (pd.InputStock - pd.OutputStock) AS Inventory
FROM Produce p JOIN ProduceDetails pd ON p.ProduceId = pd.ProduceId