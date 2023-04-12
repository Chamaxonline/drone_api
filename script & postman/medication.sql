

INSERT INTO [dbo].[Medication]
           ([CreatedDate]
           ,[Name]
           ,[Weight]
           ,[Code]
           ,[Image])
     VALUES
           (GETDATE(),
		   'Aspirin',
		   0.081,
		   'Asp_081',
		   'https://medmate.com.au/wp-content/uploads/2022/05/Blogs.png'
		   ),
		   (GETDATE(),
		   'Liraglutide',
		   0.060,
		   'Lir_060',
'https://medmate.com.au/wp-content/uploads/2022/05/Blogs.png'		   ),
		    (GETDATE(),
		   'Tirzepatide',
		   0.007,
		   'Tir_007',
'https://medmate.com.au/wp-content/uploads/2022/05/Blogs.png'		   ),
		   (GETDATE(),
		   'Naltrexone',
		   0.080,
		   'Nal_080',
'https://medmate.com.au/wp-content/uploads/2022/05/Blogs.png'		   ),
		   (GETDATE(),
		   'Orlistat',
		   0.081,
		   'Orl_081',
'https://medmate.com.au/wp-content/uploads/2022/05/Blogs.png'		   )




