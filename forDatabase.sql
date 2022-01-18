/***READ ME***/
/*
   -Make new Database namely imsDB in your SSMS
   -Make new query 
   -Copy and paste this all and execute
   -Also set configuration in first window of application
   -Use username: admin password: admin for first time
*/

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categories](
	[cat_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_name] [varchar](20) NOT NULL,
	[cat_isactive] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[productPrice]    Script Date: 04-Jun-20 10:01:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productPrice](
	[pp_proID] [bigint] NOT NULL,
	[pp_buyingPrice] [money] NOT NULL,
	[pp_sellingPrice] [money] NULL,
	[pp_discount] [float] NULL,
	[pp_profit] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[products]    Script Date: 04-Jun-20 10:01:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[products](
	[pro_id] [bigint] IDENTITY(1,1) NOT NULL,
	[pro_name] [varchar](20) NOT NULL,
	[pro_barcode] [nvarchar](100) NOT NULL,
	[pro_expiry] [date] NULL,
	[pro_catID] [int] NOT NULL,
 CONSTRAINT [PK__products__335E4CA6B9CDFD0F] PRIMARY KEY CLUSTERED 
(
	[pro_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[purchaseInvoice]    Script Date: 04-Jun-20 10:01:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchaseInvoice](
	[pi_id] [bigint] IDENTITY(1,1) NOT NULL,
	[pi_date] [date] NOT NULL,
	[pi_doneBy] [int] NOT NULL,
	[pi_suppID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[pi_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[purchaseInvoiceDetails]    Script Date: 04-Jun-20 10:01:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchaseInvoiceDetails](
	[pid_id] [bigint] IDENTITY(1,1) NOT NULL,
	[pid_purchaseid] [bigint] NOT NULL,
	[pid_prodID] [bigint] NOT NULL,
	[pid_proQuantity] [int] NOT NULL,
	[pid_totalPrice] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[pid_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[saleDetails]    Script Date: 04-Jun-20 10:01:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[saleDetails](
	[sd_salID] [bigint] NOT NULL,
	[sd_proID] [bigint] NOT NULL,
	[sd_quantity] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sales]    Script Date: 04-Jun-20 10:01:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[sal_id] [bigint] IDENTITY(1,1) NOT NULL,
	[sal_doneBy] [int] NOT NULL,
	[sal_date] [datetime] NOT NULL,
	[sal_totalAmount] [float] NOT NULL,
	[sal_totalDiscount] [float] NOT NULL,
	[sal_amountGiven] [float] NOT NULL,
	[sal_amountReturn] [float] NOT NULL,
	[sal_payType] [tinyint] NOT NULL,
 CONSTRAINT [PK__sales__FEF117682E1CB3B1] PRIMARY KEY CLUSTERED 
(
	[sal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stock]    Script Date: 04-Jun-20 10:01:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[st_proID] [bigint] NOT NULL,
	[st_quantity] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[supplier]    Script Date: 04-Jun-20 10:01:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[supplier](
	[sup_id] [int] IDENTITY(1,1) NOT NULL,
	[sup_company] [varchar](30) NOT NULL,
	[sup_contactPerson] [varchar](30) NOT NULL,
	[sup_phone1] [varchar](15) NOT NULL,
	[sup_phone2] [varchar](15) NULL,
	[sup_address] [nvarchar](50) NOT NULL,
	[sup_ntn] [varchar](25) NULL,
	[sup_status] [tinyint] NOT NULL,
 CONSTRAINT [PK__supplier__FB8F785F62CBE5E5] PRIMARY KEY CLUSTERED 
(
	[sup_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[trackDeletedItemsPI]    Script Date: 04-Jun-20 10:01:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trackDeletedItemsPI](
	[pi_id] [bigint] NOT NULL,
	[usr_id] [int] NOT NULL,
	[pro_id] [bigint] NOT NULL,
	[pro_quan] [int] NOT NULL,
	[del_date] [date] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[usr_id] [int] IDENTITY(1,1) NOT NULL,
	[usr_name] [varchar](20) NOT NULL,
	[usr_username] [varchar](20) NOT NULL,
	[usr_password] [varchar](20) NOT NULL,
	[usr_phone] [nvarchar](15) NOT NULL,
	[usr_email] [varchar](30) NOT NULL,
	[usr_status] [tinyint] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[usr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[categories] ON 

INSERT [dbo].[categories] ([cat_id], [cat_name], [cat_isactive]) VALUES (10, N'Dairy', 1)
INSERT [dbo].[categories] ([cat_id], [cat_name], [cat_isactive]) VALUES (11, N'Kitchen Ware', 1)
INSERT [dbo].[categories] ([cat_id], [cat_name], [cat_isactive]) VALUES (12, N'Fruit', 1)
INSERT [dbo].[categories] ([cat_id], [cat_name], [cat_isactive]) VALUES (13, N'Dry Fruits', 1)
INSERT [dbo].[categories] ([cat_id], [cat_name], [cat_isactive]) VALUES (14, N'Stationary', 1)
SET IDENTITY_INSERT [dbo].[categories] OFF
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (45, 50.0000, 57.5000, 0, 15)
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (47, 65.0000, 78.0000, 0, 20)
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (50, 35.0000, 40.3200, 0, 15.199999809265137)
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (51, 44.5000, 50.6032, 0.25, 14)
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (48, 30.0000, 32.6700, 1, 10)
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (49, 70.0000, 77.0000, 0, 10)
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (57, 100.0000, 110.0000, 0, 10)
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (58, 200.0000, 227.7000, 1, 15)
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (60, 10.0000, 10.0000, 0, 0)
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (61, 10.0000, 10.0000, 0, 0)
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (59, 15.0000, 15.0000, 0, 0)
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (62, 450.0000, 490.0500, 1, 10)
INSERT [dbo].[productPrice] ([pp_proID], [pp_buyingPrice], [pp_sellingPrice], [pp_discount], [pp_profit]) VALUES (63, 100.0000, 113.5625, 1.25, 15)
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (45, N'Apple', N'001', CAST(N'2020-07-01' AS Date), 12)
INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (47, N'Mango', N'002', CAST(N'2020-07-01' AS Date), 12)
INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (48, N'Dairy Milk', N'003', CAST(N'2020-07-01' AS Date), 10)
INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (49, N'KitKat', N'004', CAST(N'2020-07-01' AS Date), 10)
INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (50, N'Plates', N'005', NULL, 11)
INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (51, N'Spoon', N'006', NULL, 11)
INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (57, N'Almonds', N'007', CAST(N'2020-07-02' AS Date), 13)
INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (58, N'Injeer', N'008', CAST(N'2020-07-02' AS Date), 13)
INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (59, N'Pencil', N'009', NULL, 14)
INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (60, N'Eraser', N'010', NULL, 14)
INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (61, N'Sharpener', N'011', NULL, 14)
INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (62, N'Kaju', N'012', CAST(N'2020-08-04' AS Date), 13)
INSERT [dbo].[products] ([pro_id], [pro_name], [pro_barcode], [pro_expiry], [pro_catID]) VALUES (63, N'Orange', N'013', CAST(N'2020-08-04' AS Date), 12)
SET IDENTITY_INSERT [dbo].[products] OFF
SET IDENTITY_INSERT [dbo].[purchaseInvoice] ON 

INSERT [dbo].[purchaseInvoice] ([pi_id], [pi_date], [pi_doneBy], [pi_suppID]) VALUES (36, CAST(N'2020-06-01' AS Date), 13, 8)
INSERT [dbo].[purchaseInvoice] ([pi_id], [pi_date], [pi_doneBy], [pi_suppID]) VALUES (37, CAST(N'2020-06-02' AS Date), 13, 8)
INSERT [dbo].[purchaseInvoice] ([pi_id], [pi_date], [pi_doneBy], [pi_suppID]) VALUES (38, CAST(N'2020-06-04' AS Date), 15, 11)
SET IDENTITY_INSERT [dbo].[purchaseInvoice] OFF
SET IDENTITY_INSERT [dbo].[purchaseInvoiceDetails] ON 

INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (12, 36, 45, 10, 500.0000)
INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (13, 36, 47, 10, 650.0000)
INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (14, 36, 50, 10, 350.0000)
INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (15, 36, 51, 10, 445.0000)
INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (16, 36, 48, 10, 300.0000)
INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (17, 36, 49, 10, 700.0000)
INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (18, 37, 57, 15, 1500.0000)
INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (19, 37, 58, 10, 2000.0000)
INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (20, 38, 60, 10, 100.0000)
INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (21, 38, 61, 10, 100.0000)
INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (22, 38, 59, 10, 150.0000)
INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (23, 38, 62, 10, 4500.0000)
INSERT [dbo].[purchaseInvoiceDetails] ([pid_id], [pid_purchaseid], [pid_prodID], [pid_proQuantity], [pid_totalPrice]) VALUES (24, 38, 63, 15, 1500.0000)
SET IDENTITY_INSERT [dbo].[purchaseInvoiceDetails] OFF
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (41, 45, 3)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (41, 47, 3)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (41, 48, 3)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (41, 49, 3)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (41, 50, 3)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (41, 51, 3)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (42, 45, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (42, 47, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (42, 48, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (42, 49, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (42, 50, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (42, 51, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (42, 57, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (42, 58, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 45, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 47, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 48, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 49, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 50, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 51, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 57, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 58, 1)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 59, 4)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 60, 4)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 61, 4)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 62, 4)
INSERT [dbo].[saleDetails] ([sd_salID], [sd_proID], [sd_quantity]) VALUES (43, 63, 4)
SET IDENTITY_INSERT [dbo].[sales] ON 

INSERT [dbo].[sales] ([sal_id], [sal_doneBy], [sal_date], [sal_totalAmount], [sal_totalDiscount], [sal_amountGiven], [sal_amountReturn], [sal_payType]) VALUES (41, 13, CAST(N'2020-06-01 12:08:05.100' AS DateTime), 1007, 1, 5000, 3993, 1)
INSERT [dbo].[sales] ([sal_id], [sal_doneBy], [sal_date], [sal_totalAmount], [sal_totalDiscount], [sal_amountGiven], [sal_amountReturn], [sal_payType]) VALUES (42, 13, CAST(N'2020-06-02 22:34:07.707' AS DateTime), 671, 3, 1000, 329, 0)
INSERT [dbo].[sales] ([sal_id], [sal_doneBy], [sal_date], [sal_totalAmount], [sal_totalDiscount], [sal_amountGiven], [sal_amountReturn], [sal_payType]) VALUES (43, 15, CAST(N'2020-06-04 11:38:16.033' AS DateTime), 3200, 28, 5000, 1800, 1)
SET IDENTITY_INSERT [dbo].[sales] OFF
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (45, 5)
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (47, 5)
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (50, 5)
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (51, 5)
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (48, 5)
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (49, 5)
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (57, 13)
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (58, 8)
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (60, 6)
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (61, 6)
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (59, 6)
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (62, 6)
INSERT [dbo].[stock] ([st_proID], [st_quantity]) VALUES (63, 11)
SET IDENTITY_INSERT [dbo].[supplier] ON 

INSERT [dbo].[supplier] ([sup_id], [sup_company], [sup_contactPerson], [sup_phone1], [sup_phone2], [sup_address], [sup_ntn], [sup_status]) VALUES (8, N'Rafiq Confectionary', N'Rafiq Khan', N'0340-22222222', N'', N'bufferzon,Karachi', N'034-211', 1)
INSERT [dbo].[supplier] ([sup_id], [sup_company], [sup_contactPerson], [sup_phone1], [sup_phone2], [sup_address], [sup_ntn], [sup_status]) VALUES (11, N'Farhan Factory', N'Farhan Khan', N'0123-01121121', N'0123-09999121', N'Gulistan e Johar', N'012-123', 1)
SET IDENTITY_INSERT [dbo].[supplier] OFF
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([usr_id], [usr_name], [usr_username], [usr_password], [usr_phone], [usr_email], [usr_status]) VALUES (13, N'Sumair Ahmed', N'admin', N'admin', N'0900786011', N'admin@admin.admin', 1)
INSERT [dbo].[users] ([usr_id], [usr_name], [usr_username], [usr_password], [usr_phone], [usr_email], [usr_status]) VALUES (15, N'Abdul Rehman', N'abdul', N'abdul', N'090078601', N'abdul.rehman@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[users] OFF
/****** Object:  Index [UQ__productP__91A6C9056E6ED27B]    Script Date: 04-Jun-20 10:01:22 PM ******/
ALTER TABLE [dbo].[productPrice] ADD UNIQUE NONCLUSTERED 
(
	[pp_proID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [barcodeUnique]    Script Date: 04-Jun-20 10:01:22 PM ******/
ALTER TABLE [dbo].[products] ADD  CONSTRAINT [barcodeUnique] UNIQUE NONCLUSTERED 
(
	[pro_barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uniqueProduct]    Script Date: 04-Jun-20 10:01:22 PM ******/
ALTER TABLE [dbo].[products] ADD  CONSTRAINT [uniqueProduct] UNIQUE NONCLUSTERED 
(
	[pro_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__stocl__89BC7A315823D641]    Script Date: 04-Jun-20 10:01:22 PM ******/
ALTER TABLE [dbo].[stock] ADD  CONSTRAINT [UQ__stocl__89BC7A315823D641] UNIQUE NONCLUSTERED 
(
	[st_proID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_username]    Script Date: 04-Jun-20 10:01:22 PM ******/
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [IX_username] UNIQUE NONCLUSTERED 
(
	[usr_username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_users_email]    Script Date: 04-Jun-20 10:01:22 PM ******/
ALTER TABLE [dbo].[users] ADD  CONSTRAINT [IX_users_email] UNIQUE NONCLUSTERED 
(
	[usr_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[productPrice]  WITH CHECK ADD FOREIGN KEY([pp_proID])
REFERENCES [dbo].[products] ([pro_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK__products__pro_ca__1FCDBCEB] FOREIGN KEY([pro_catID])
REFERENCES [dbo].[categories] ([cat_id])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK__products__pro_ca__1FCDBCEB]
GO
ALTER TABLE [dbo].[purchaseInvoiceDetails]  WITH CHECK ADD FOREIGN KEY([pid_purchaseid])
REFERENCES [dbo].[purchaseInvoice] ([pi_id])
GO
ALTER TABLE [dbo].[purchaseInvoiceDetails]  WITH CHECK ADD FOREIGN KEY([pid_prodID])
REFERENCES [dbo].[products] ([pro_id])
GO
ALTER TABLE [dbo].[saleDetails]  WITH CHECK ADD  CONSTRAINT [FK__saleDetai__sd_sa__7E37BEF6] FOREIGN KEY([sd_salID])
REFERENCES [dbo].[sales] ([sal_id])
GO
ALTER TABLE [dbo].[saleDetails] CHECK CONSTRAINT [FK__saleDetai__sd_sa__7E37BEF6]
GO
ALTER TABLE [dbo].[trackDeletedItemsPI]  WITH CHECK ADD  CONSTRAINT [FK__trackDele__pro_i__5812160E] FOREIGN KEY([pro_id])
REFERENCES [dbo].[products] ([pro_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[trackDeletedItemsPI] CHECK CONSTRAINT [FK__trackDele__pro_i__5812160E]
GO
/****** Object:  StoredProcedure [dbo].[st_checkProductPriceExist]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_checkProductPriceExist]
@proID bigint
as
select * from productPrice where pp_proID = @proID
GO
/****** Object:  StoredProcedure [dbo].[st_deleteCategory]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_deleteCategory]
@id int
as
delete from categories where cat_id=@id
GO
/****** Object:  StoredProcedure [dbo].[st_deleteProduct]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_deleteProduct]
@id bigint
as delete from products 
where pro_id=@id;
GO
/****** Object:  StoredProcedure [dbo].[st_deleteProductFROMPI]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create procedure [dbo].[st_deleteProductFROMPI]
 @mPID bigint
 as
 delete from purchaseInvoiceDetails
 where pid_id = @mPID
GO
/****** Object:  StoredProcedure [dbo].[st_deleteSupplier]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_deleteSupplier]
@suppID int
as 
delete from supplier where sup_id = @suppID
GO
/****** Object:  StoredProcedure [dbo].[st_deleteUsers]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_deleteUsers] 
@id int
as delete from users 
where usr_id=@id;
GO
/****** Object:  StoredProcedure [dbo].[st_getAllStock]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getAllStock]

as select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
format(p.pro_expiry,'dd-MMM-yyyy') as 'Expiry Date',
pp.pp_buyingPrice as 'Buying Price',
pp.pp_sellingPrice as 'Selling Price',
c.cat_name as 'Category',
s.st_quantity as 'Available Stock',
case when (s.st_quantity < 50 ) then 'Low' else case when (s.st_quantity < 100 and s.st_quantity > 50 ) 
then 'Average' else case when (s.st_quantity >=100) then 'Good' end end end as 'Status',
pp.pp_buyingPrice  * s.st_quantity as 'Total Amount'
from stock s
inner join products p
on p.pro_id = s.st_proID
inner join categories c
on c.cat_id = p.pro_catID
inner join productPrice pp 
on p.pro_id= pp.pp_proID

GO
/****** Object:  StoredProcedure [dbo].[st_getAllStockLike]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getAllStockLike]
@data varchar(100)
as select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
format(p.pro_expiry,'dd-MMM-yyyy') as 'Expiry Date',
pp.pp_buyingPrice as 'Buying Price',
pp.pp_sellingPrice as 'Selling Price',
c.cat_name as 'Category',
s.st_quantity as 'Available Stock'
from stock s
inner join products p
on p.pro_id = s.st_proID
inner join categories c
on c.cat_id = p.pro_catID
inner join productPrice pp 
on p.pro_id= pp.pp_proID
where p.pro_id like '%'+@data+'%'
or 
p.pro_name like '%'+@data+'%'
or
p.pro_barcode like '%'+@data+'%'
or
p.pro_expiry like '%'+@data+'%'
or
pp.pp_buyingPrice like '%'+@data+'%'
or 
pp.pp_sellingPrice like '%'+@data+'%'
or
c.cat_name like '%'+@data+'%'
or
s.st_quantity like '%'+@data+'%'


order by p.pro_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getCategoryData]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getCategoryData]
as
select
c.cat_id as 'ID',
c.cat_name as 'name',
case when (c.cat_isactive = 1) then 'Yes' else 'No' end as 'Status'
from categories c
order by c.cat_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getCategoryDataLike]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getCategoryDataLike]
@data varchar(50)
as 
select
	c.cat_id as 'ID',
	c.cat_name as 'Name',
case when (c.cat_isactive = 1) then 'Yes' else 'No' end as 'Status'
from categories c
where c.cat_ID like '%'+@data+'%'
or 
c.cat_name like '%'+@data+'%'

order by c.cat_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getCategoryList]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getCategoryList]
as 
select c.cat_id as 'ID',
c.cat_name as 'Category'
from categories c 
order by c.cat_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getDailySales]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getDailySales]
@date date
as
select distinct
s.sal_id as 'Sale ID',
s.sal_totalAmount as 'Total Amount',
s.sal_amountGiven as 'Amount Given',
s.sal_amountReturn as 'Amount Return',
u.usr_name as 'User',
u.usr_id as 'User ID',
s.sal_totalDiscount as 'Total Discount'
from sales s
inner join saleDetails sd
on s.sal_id = sd.sd_salID
inner join users u
on u.usr_id = s.sal_doneBy
where convert (date, s.sal_date) = @date
GO
/****** Object:  StoredProcedure [dbo].[st_getLastPurchaseID]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getLastPurchaseID]
as 
select top 1 pii.pi_id from purchaseInvoice pii order by pii.pi_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_getProductByBarcode]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getProductByBarcode]
@barcode nvarchar(100)
as
select 
p.pro_id as 'Product ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
pp.pp_sellingPrice as 'Selling Price',
pp.pp_sellingPrice * pp.pp_discount /100 'Discount',
pp.pp_sellingPrice-(pp.pp_sellingPrice * pp.pp_discount/100) as 'Final Selling Price'
from products p 
inner join productPrice pp
on p.pro_id = pp.pp_proID
where p.pro_barcode = @barcode


GO
/****** Object:  StoredProcedure [dbo].[st_getProductByBarcode1]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getProductByBarcode1]
@barcode nvarchar(100)
as
select 
p.pro_id as 'Product ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode'
from products p 
where p.pro_barcode = @barcode
GO
/****** Object:  StoredProcedure [dbo].[st_getProductData]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getProductData]
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
format (p.pro_expiry,'dd-MMM-yyyy') as 'Expiry',
p.pro_barcode as 'barcode',
c.cat_name as 'Category',
c.cat_id as 'Category ID'
from products p
inner join categories c
on c.cat_id = p.pro_catID
GO
/****** Object:  StoredProcedure [dbo].[st_getProductDataLike]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getProductDataLike]
@data varchar(100)
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
format (p.pro_expiry,'dd-MMM-yyyy') as 'Expiry',
p.pro_barcode as 'barcode',
c.cat_name as 'Category',
c.cat_id as 'Category ID'
from products p
inner join categories c
on c.cat_id = p.pro_catID
where p.pro_id  like '%'+@data+'%'
or 
p.pro_name  like '%'+@data+'%'
or
p.pro_expiry like '%'+@data+'%'
or
p.pro_barcode like '%'+@data+'%'
or
c.cat_name like '%'+@data+'%'
or
c.cat_id like '%'+@data+'%'

order by p.pro_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getProductQuantity]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_getProductQuantity]
@proID bigint
as
select s.st_quantity as 'Quantity'
from stock s
where s.st_proID = @proID
GO
/****** Object:  StoredProcedure [dbo].[st_getProdutswrtCategory]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getProdutswrtCategory]
@catID int
as		
select 
p.pro_id as 'Product ID',
p.pro_name as 'Product',
pp.pp_buyingPrice as'Buying Price',
case when (pp.pp_sellingPrice is null) then 0 else pp.pp_sellingPrice end 'Selling Price',
case when (pp.pp_discount is null ) then 0 else pp.pp_discount end as 'Discount',
case when (pp.pp_profit is null) then 0 else pp.pp_profit end as  'Profit Margin'
from products p
inner join productPrice pp
on p.pro_id = pp.pp_proID
inner join categories c
on c.cat_id = p.pro_catID
where c.cat_id= @catID
GO
/****** Object:  StoredProcedure [dbo].[st_getPurchaseInvoiceDeatils]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getPurchaseInvoiceDeatils]
@pid bigint
as
select
pid.pid_prodID as 'Product ID',
pid.pid_id as 'mPID',
p.pro_name as 'Product',
pid.pid_proQuantity as 'Quantity',
pid.pid_totalPrice as 'Total Price',
pp.pp_buyingPrice as 'Per Unit Price'
 from purchaseInvoice pii
inner join purchaseInvoiceDetails pid
inner join products p on p.pro_id=pid.pid_prodID
on pii.pi_id = pid.pid_purchaseid
inner join productPrice pp
on p.pro_id=pp.pp_proID
where pii.pi_id = @pid
GO
/****** Object:  StoredProcedure [dbo].[st_getPurchaseInvoiceList]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getPurchaseInvoiceList]
@month int,
@year int
as 
select 
pii.pi_id as 'ID',
su.sup_company+' ' +format(pii.pi_date,'dd-MMM-yyyy') as 'Company'
from purchaseInvoice pii
inner join supplier su
on su.sup_id = pii.pi_suppID
where
month(pii.pi_date) = @month and year(pii.pi_date) = @year
GO
/****** Object:  StoredProcedure [dbo].[st_getSaleReceipt]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_getSaleReceipt]
@userID int
as 
select
s.sal_id as 'Sale ID',
p.pro_barcode as 'Barcode',
p.pro_name as 'Product Name',
sd.sd_quantity as 'Quantity',
s.sal_totalDiscount as 'Total Discount',
s.sal_totalAmount as 'Total Amount',
s.sal_amountGiven as 'Amount Given',
s.sal_amountReturn as 'Amount Return',
format(s.sal_date,'dd-MMM-yyyy hh:mm:ss tt') as 'Date',
pp.pp_sellingPrice as 'Product Price',
((pp.pp_sellingPrice*pp.pp_discount/100) * sd.sd_quantity) as 'Per Product Discount',
(pp.pp_sellingPrice * sd.sd_quantity) - (((pp.pp_sellingPrice*pp.pp_discount/100) * sd.sd_quantity )) as 'Per Product Total',
u.usr_name as 'User Name',
case when (s.sal_payType=0) then 'Cash' else case when (s.sal_payType=1) then 'Debit Card' else case when (s.sal_payType=2) then 'Credit Card'end end end as 'Pay Type'
from	sales s 
inner join saleDetails sd 
on s.sal_id = sd.sd_salID
inner join products p
on p.pro_id = sd.sd_proID 
inner join productPrice pp
on pp.pp_proID = p.pro_id
inner join users u 
on u.usr_id = s.sal_doneBy
where s.sal_id =(select top 1 ss.sal_id from sales ss order by ss.sal_id desc)
and u.usr_id = @userID
order by s.sal_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_getSaleReceiptWRTSaleID]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getSaleReceiptWRTSaleID]
@saleID bigint
as 
select
s.sal_id as 'Sale ID',
p.pro_barcode as 'Barcode',
p.pro_name as 'Product Name',
p.pro_id as 'Product ID',
sd.sd_quantity as 'Quantity',
s.sal_totalDiscount as 'Total Discount',
s.sal_totalAmount as 'Total Amount',
s.sal_amountGiven as 'Amount Given',
s.sal_amountReturn as 'Amount Return',
format(s.sal_date,'dd-MMM-yyyy hh:mm:ss tt') as 'Date',
pp.pp_sellingPrice as 'Product Price',
((pp.pp_sellingPrice*pp.pp_discount/100) * sd.sd_quantity) as 'Per Product Discount',
(pp.pp_sellingPrice * sd.sd_quantity) - (((pp.pp_sellingPrice*pp.pp_discount/100) * sd.sd_quantity )) as 'Per Product Total',
u.usr_name as 'User Name',
case when (s.sal_payType=0) then 'Cash' else case when (s.sal_payType=1) then 'Debit Card' else case when (s.sal_payType=2) then 'Credit Card'end end end as 'Pay Type'
from	sales s 
inner join saleDetails sd 
on s.sal_id = sd.sd_salID
inner join products p
on p.pro_id = sd.sd_proID 
inner join productPrice pp
on pp.pp_proID = p.pro_id
inner join users u 
on u.usr_id = s.sal_doneBy
where s.sal_id = @saleID
order by s.sal_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_getSalesID]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getSalesID]
as
select top 1 s.sal_id as 'Sales ID' from sales s order by s.sal_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_getSupplierData]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getSupplierData]
as
select 
	s.sup_id as 'ID',
	s.sup_company as 'Company',
	s.sup_contactPerson as 'Contact Person',
	s.sup_phone1  as 'Phone 1',
	s.sup_phone2  as 'Phone 2',
	s.sup_address  as 'NTN #',
	s.sup_ntn  as 'Address',
case when (s.sup_status = 1) then 'Active' else 'In-active' end as 'Status'
from supplier s order by s.sup_company asc
GO
/****** Object:  StoredProcedure [dbo].[st_getSupplierDataLike]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getSupplierDataLike]
@data varchar(100)
as
select 
	s.sup_id as 'ID',
	s.sup_company as 'Company',
	s.sup_contactPerson as 'Contact Person',
	s.sup_phone1  as 'Phone 1',
	s.sup_phone2  as 'Phone 2',
	s.sup_address  as 'NTN #',
	s.sup_ntn  as 'Address',
case when (s.sup_status = 1) then 'Active' else 'In-active' end as 'Status'
from supplier s 
where s.sup_id  like '%'+@data+'%'
or 
s.sup_company  like '%'+@data+'%'
or
s.sup_contactPerson like '%'+@data+'%'
or
s.sup_phone1 like '%'+@data+'%'
or
s.sup_phone2 like '%'+@data+'%'
or
s.sup_address like '%'+@data+'%'
or
s.sup_ntn like '%'+@data+'%'
order by s.sup_company asc
GO
/****** Object:  StoredProcedure [dbo].[st_getSupplierList]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getSupplierList]
as 
select s.sup_id as 'ID',
s.sup_company as 'Company'
from supplier s where 
s.sup_status = 1 order by s.sup_company asc 
GO
/****** Object:  StoredProcedure [dbo].[st_getUserData]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getUserData]
as 
select
u.usr_id as 'ID',
u.usr_name as 'Name',
u.usr_username as 'Username',
u.usr_password as 'Password',
u.usr_phone as 'Phone',
u.usr_email as 'Email',
case when (usr_status = 1) then 'Active' else 'In-Active' end as 'Status'
from users u
order by u.usr_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getUserDataLike]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getUserDataLike]
@data varchar(50)
as 
select
	u.usr_id as 'ID',
	u.usr_name as 'Name',
	u.usr_username as 'Username',
	u.usr_password as 'Password',
	u.usr_phone as 'Phone',
	u.usr_email as 'Email',
case when (usr_status = 1) then 'Active' else 'In-Active' end as 'Status'
from users u
where u.usr_id like '%'+@data+'%'
or 
u.usr_name like '%'+@data+'%'
or
u.usr_phone like '%'+@data+'%'
or
u.usr_email like '%'+@data+'%'

order by u.usr_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getUserDetails]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getUserDetails]
@user varchar(20),
@pass varchar(20)
as
select
u.usr_id as 'ID',
u.usr_name as 'Name',
u.usr_username as 'Username',
u.usr_password as 'Password'
from users u
where u.usr_username = @user
and 
u.usr_password = @pass
GO
/****** Object:  StoredProcedure [dbo].[st_insertCategory]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertCategory]
@name varchar(20),
@isactive tinyint
as insert into categories values (@name,@isactive)
GO
/****** Object:  StoredProcedure [dbo].[st_insertDeletedItemPI]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[st_insertDeletedItemPI]
 @pi bigint,
 @usrid int,
 @proID bigint,
 @quan int,
 @date date
 as
 insert into trackDeletedItemsPI values(@pi,@usrid,@proID,@quan,@date)
GO
/****** Object:  StoredProcedure [dbo].[st_insertProduct]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertProduct]
@name varchar(20),
@barcode nvarchar(100),
@expiry date,
@catID int
as
insert into products values (@name,@barcode,@expiry,@catID)
GO
/****** Object:  StoredProcedure [dbo].[st_insertProductPrice]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertProductPrice]
@proID bigint,
@buyingPrice money
as 
insert into productPrice (pp_proID,pp_buyingPrice) values (@proID,@buyingPrice)
GO
/****** Object:  StoredProcedure [dbo].[st_insertPurchaseInvoice]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertPurchaseInvoice]
@date date,
@doneBy int,
@suppID int
as
insert into purchaseInvoice values(@date,@doneBy,@suppID)
GO
/****** Object:  StoredProcedure [dbo].[st_insertPurchaseInvoiceDetails]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertPurchaseInvoiceDetails]
@purchaseID bigint,
@prodID int,
@proQuan int,
@totalPrice money
as
insert into purchaseInvoiceDetails values(@purchaseID,@prodID,@proQuan,@totalPrice)
GO
/****** Object:  StoredProcedure [dbo].[st_insertrefund]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertrefund]
@date date,
@doneby int,
@proID bigint,
@quantity tinyint,
@amount money,
@saleID bigint
as
insert into refunds_return values (@date,@doneby,@proID,@quantity,@amount,@saleID)
GO
/****** Object:  StoredProcedure [dbo].[st_insertSaleDetails]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_insertSaleDetails]
@salID bigint,
@proID bigint,
@quan int
as 
insert into saleDetails values (@salID,@proID,@quan)
GO
/****** Object:  StoredProcedure [dbo].[st_insertSales]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertSales]
@done int,
@date datetime,
@totalAmount float,
@totalDiscount float, 
@given float,
@return float,
@payType tinyint --0 means Cash 1 means Debit Card 2 means Credit Card
as
insert into sales values (@done,@date,@totalAmount,@totalDiscount,@given,@return,@payType)
GO
/****** Object:  StoredProcedure [dbo].[st_insertStock]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertStock]
@proID bigint,
@quan int
as 
insert into stock values (@proID,@quan)
GO
/****** Object:  StoredProcedure [dbo].[st_insertSupplier]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertSupplier]
@company varchar(30),
@conPerson varchar(30),
@phone1 varchar(15),
@phone2 varchar(15),
@address nvarchar(50),
@ntn varchar(25),
@status tinyint
as
insert into supplier values (@company,@conPerson,@phone1,@phone2,@address,@ntn,@status)

GO
/****** Object:  StoredProcedure [dbo].[st_insertUsers]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertUsers]
@name varchar(20),
@username varchar(20),
@password nvarchar(20),
@phone varchar(15),
@email varchar(30),
@status tinyint
as insert into users(usr_name,usr_username,usr_password,usr_phone,usr_email,usr_status) values(@name,@username,@password,@phone,@email,@status)
GO
/****** Object:  StoredProcedure [dbo].[st_updateCategory]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_updateCategory]
@name varchar(20),
@isactive tinyint,
@id int
as
update categories
set 
cat_name=@name,
cat_isactive=@isactive
where 
cat_id=@id
GO
/****** Object:  StoredProcedure [dbo].[st_updateProduct]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_updateProduct]
@name varchar(20),
@barcode nvarchar(100),
@expiry date,
@catID int,
@id bigint
as
update products set
pro_name=@name,
pro_catID=@catID,
pro_barcode=@barcode,
pro_expiry=@expiry
where
pro_id=@id
GO
/****** Object:  StoredProcedure [dbo].[st_updateProductPrice]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_updateProductPrice] 
@proID bigint,
@buyingPrice money,
@sp money,
@disc float,
@profit float
as
update productPrice 
set 
pp_buyingPrice =@buyingPrice,
pp_sellingPrice=@sp,
pp_discount= @disc,
pp_profit = @profit
where 
pp_proID=@proID
GO
/****** Object:  StoredProcedure [dbo].[st_updateProductPrice1]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_updateProductPrice1]
@proID bigint,
@buyingPrice money
as
update productPrice 
set 
pp_buyingPrice =@buyingPrice
where 
pp_proID=@proID
GO
/****** Object:  StoredProcedure [dbo].[st_updateStock]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_updateStock]
@quan int,
@proID int 
as 
update stock
set st_quantity = @quan
where 
st_proID =@proID

GO
/****** Object:  StoredProcedure [dbo].[st_updateSupplier]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_updateSupplier]
@company varchar(30),
@conPerson varchar(30),
@phone1 varchar(15),
@phone2 varchar(15),
@address nvarchar(50),
@ntn varchar(25),
@status tinyint,
@suppID int
as 
update supplier
set
sup_company = @company,
sup_contactPerson = @conPerson,
sup_phone1 = @phone1,
sup_phone2 = @phone2,
sup_address = @address,
sup_ntn = @ntn,
sup_status = @status
where
sup_id = @suppID
GO
/****** Object:  StoredProcedure [dbo].[st_updateUsers]    Script Date: 04-Jun-20 10:01:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_updateUsers]
@name varchar(20),
@username varchar(20),
@password nvarchar(20),
@phone varchar(15),
@email varchar(30),
@id int,
@status tinyint
as
update users set
usr_name=@name,
usr_username=@username,
usr_password=@password,
usr_phone=@phone,
usr_email=@email,
usr_status = @status
where
usr_id=@id
GO
USE [master]
GO
ALTER DATABASE [imsDB] SET  READ_WRITE 
GO
