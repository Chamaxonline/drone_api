
INSERT INTO [dbo].[DroneMedication]
           ([CreatedDate]
           ,[DroneId]
           ,[MedicationId]
           ,[MedicationQty]
           ,[TotalWeight]
           ,[Active])
     VALUES
           (GETDATE(),
		   5,
		   2,
		   4000,
		   240,
		   1),
		    (GETDATE(),
		   6,
		   5,
		   3500,
		   280,
		   1),
		    (GETDATE(),
		   7,
		   1,
		   4500,
		   360,
		   1)



