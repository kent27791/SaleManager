SELECT * 
FROM Stock
WHERE ProduceId = 'SP-001'

ALTER TRIGGER trStock
ON Stock
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
	SET NOCOUNT OFF
	DECLARE @ProduceId NVARCHAR(10)
	DECLARE @TotalImport INT
	DECLARE @TotalExport INT
	DECLARE @Quantity INT

	SELECT * FROM inserted
	SELECT * FROM deleted
	SELECT @ProduceId = ProduceId FROM inserted

	IF(@ProduceId IS NULL)
	BEGIN
		SET @ProduceId = (SELECT ProduceId FROM deleted GROUP BY ProduceId)
	END
	IF(@ProduceId IS NOT NULL)
	BEGIN
		SELECT @TotalImport = SUM(Quantity)
		FROM Stock WHERE CheckInOut = 1 AND ProduceId = @ProduceId
		SET @TotalImport = ISNULL(@TotalImport, 0)

		SELECT @TotalExport = SUM(Quantity)
		FROM Stock WHERE CheckInOut = 0 AND ProduceId = @ProduceId
		SET @TotalExport = ISNULL(@TotalExport, 0)

		SET @Quantity = @TotalImport - @TotalExport

		IF(NOT EXISTS(SELECT (1) FROM Inventory WHERE ProduceId = @ProduceId))
			BEGIN
				INSERT INTO Inventory VALUES(@ProduceId, @Quantity, @TotalImport, @TotalExport)
			END
		ELSE
			BEGIN
				UPDATE Inventory SET [Quantity] = @Quantity, [TotalImport] = @TotalImport, [TotalExport] = @TotalExport
				WHERE [ProduceId] = @ProduceId
			END
	END
END


INSERT INTO Stock VALUES('SP-001','2014-10-10',15 ,0)

