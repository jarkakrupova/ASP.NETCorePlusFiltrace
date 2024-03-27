
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231129081520_init', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231201072756_subjectsAdded', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231201080330_gradesAdded', N'6.0.25')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231204074046_IdentityAdded', N'6.0.25')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'83a03314-6319-44f2-998a-f872e43707d0', N'Student', N'STUDENT', N'1f1962bb-6e54-469c-9914-e3f6e340303b')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd6f888f3-8991-4864-9fa8-82366e2ec382', N'Admin', N'ADMIN', N'1f62cc4d-6590-4e4f-a305-cefd393e6a65')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'fff6ea46-5001-46db-af0a-5a02e4198fbd', N'Teacher', N'TEACHER', N'abce51c3-ff28-4756-a17e-f0476052f3ed')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4cd2853f-9137-482b-9af0-1b945de72dc1', N'83a03314-6319-44f2-998a-f872e43707d0')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4f9259eb-ad88-4c0f-8c33-c0ed27d7ac6f', N'83a03314-6319-44f2-998a-f872e43707d0')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a0abf39f-b897-45cb-9e90-606c99481492', N'83a03314-6319-44f2-998a-f872e43707d0')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c88fdb0d-ad8a-4496-8460-366255e151f1', N'83a03314-6319-44f2-998a-f872e43707d0')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b268872b-eea9-4af2-9a17-3650425f0950', N'd6f888f3-8991-4864-9fa8-82366e2ec382')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a4bbba3f-1d54-4096-8569-5b9a747b5640', N'fff6ea46-5001-46db-af0a-5a02e4198fbd')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd073cc2c-9610-4fb3-bda6-7b91e2c741e6', N'fff6ea46-5001-46db-af0a-5a02e4198fbd')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4cd2853f-9137-482b-9af0-1b945de72dc1', N'Gustav', N'GUSTAV', N'gustav@gustav.cz', N'GUSTAV@GUSTAV.CZ', 0, N'AQAAAAEAACcQAAAAECg4ly1L00CwW4nIr0eD0CrUgtAAOgPB1xNSSWF2niWON1KOyML7R4kMkmOXGKWS7w==', N'MHF5EBAPWI5WKRZXYQOGDPRLDV53Z4ZQ', N'58180add-501e-4401-96df-e66fdfcc3afa', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4f9259eb-ad88-4c0f-8c33-c0ed27d7ac6f', N'Filip', N'FILIP', N'filip@filip.cz', N'FILIP@FILIP.CZ', 0, N'AQAAAAEAACcQAAAAELCfwgnRgIywg2rNuYvIZ3+CV/zzDd9GywEDqEgFcDkNPA3AsjogzxBbTWRC+GpmEg==', N'56DIXC6VQW4KZB4VDGL64ZOQ5UFO7FBK', N'667f5788-20fd-40ec-9def-26f0c2e45e89', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a0abf39f-b897-45cb-9e90-606c99481492', N'Renata', N'RENATA', N'renata@renata.cz', N'RENATA@RENATA.CZ', 0, N'AQAAAAEAACcQAAAAECIRomSvradabCsixjXfs2P2Ry+mesp/b2vPYbqS0O75BVMkG2lY2i3TX2eR1ZNRsw==', N'DOQW7INTFPBTEIIFIBHTCUCBIYRUUXEF', N'0d87b544-2b13-401c-abed-21f066ca03b7', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a4bbba3f-1d54-4096-8569-5b9a747b5640', N'telocvikar', N'TELOCVIKAR', N'telocvikar@telocvikar.cz', N'TELOCVIKAR@TELOCVIKAR.CZ', 0, N'AQAAAAEAACcQAAAAEHgruya87KUauiuonswmzIaano4DG2OKDsat+UMjFD7XiJiDnwYQSi61YobCFrdJiQ==', N'K5XMRFQPJZDWG4R6ZSRS2XCD6EFLGO33', N'741a8ea0-69a1-4e02-a754-8dab253517db', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b268872b-eea9-4af2-9a17-3650425f0950', N'admin', N'ADMIN', N'admin@admin.cz', N'ADMIN@ADMIN.CZ', 0, N'AQAAAAEAACcQAAAAEJZnVI6XnY8HRryMZdPqUo8Rcjv/JSmf/cba098CYAY01hcZ+u9l2uyG0lYA9hhNTQ==', N'4JECM33UEPKKTCSRP52F3KRC74ON7IFC', N'747db880-b97c-4fd0-9265-bc524c930555', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c88fdb0d-ad8a-4496-8460-366255e151f1', N'Klotylda', N'KLOTYLDA', N'klotylda@klotylda.cz', N'KLOTYLDA@KLOTYLDA.CZ', 0, N'AQAAAAEAACcQAAAAEFF5zykeBTdM0RPAxMFuIAF2yyUJvBdmSd17mbJdsYhTHM/Bg8YzIiHZlziZVG8Fjw==', N'A7BMIV2TSOP7H6DY32NLT4IOJ4IA5NUQ', N'c27c7686-e0ae-4366-88cf-4efb549ca565', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'd073cc2c-9610-4fb3-bda6-7b91e2c741e6', N'matikar', N'MATIKAR', N'matikar@matikar.cz', N'MATIKAR@MATIKAR.CZ', 0, N'AQAAAAEAACcQAAAAEDUYnajxt8+pWkmmrfKYNiPz2tsrr6p3zlutT2gsDzg4Ib3qPeVLgFna8ZieOEfN+Q==', N'UJ4JLFJRQPMUJJ4SI4CLCTJQRG42X2AA', N'bd4b0409-6881-4b3d-ad7d-bc5dddf20291', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Grades] ON 

INSERT [dbo].[Grades] ([Id], [SubjectId], [Mark], [What], [Date], [StudentId]) VALUES (6, 1, 2, N'Asie', CAST(N'2023-12-02T00:00:00.0000000' AS DateTime2), 4)
INSERT [dbo].[Grades] ([Id], [SubjectId], [Mark], [What], [Date], [StudentId]) VALUES (7, 3, 2, N'lomené výrazy', CAST(N'2023-12-08T00:00:00.0000000' AS DateTime2), 10)
SET IDENTITY_INSERT [dbo].[Grades] OFF
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [DateOfBirth]) VALUES (3, N'José', N'Chroustal', CAST(N'2002-04-06T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [DateOfBirth]) VALUES (4, N'Adam', N'Navrátil', CAST(N'2003-06-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [DateOfBirth]) VALUES (5, N'Klemens', N'Chasles', CAST(N'2002-03-26T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [DateOfBirth]) VALUES (6, N'Wylma', N'Desantis', CAST(N'2005-05-24T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [DateOfBirth]) VALUES (7, N'Morgan', N'Knight', CAST(N'2001-04-14T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [DateOfBirth]) VALUES (8, N'Abigael', N'Navein', CAST(N'2000-12-16T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [DateOfBirth]) VALUES (9, N'Orsola', N'Bushen', CAST(N'2001-07-28T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [DateOfBirth]) VALUES (10, N'Grover', N'MacFall', CAST(N'2003-12-28T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [DateOfBirth]) VALUES (11, N'Westleigh', N'Coulthard', CAST(N'2003-02-06T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [DateOfBirth]) VALUES (12, N'Pip', N'Gammade', CAST(N'2000-05-14T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [DateOfBirth]) VALUES (13, N'Heddie', N'Enterle', CAST(N'2002-07-22T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Students] ([Id], [FirstName], [LastName], [DateOfBirth]) VALUES (14, N'Lucy', N'Mycock', CAST(N'2001-08-17T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Students] OFF
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (1, N'Fyzika')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (3, N'Matematika')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (4, N'Zeměpis')
SET IDENTITY_INSERT [dbo].[Subjects] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 08.12.2023 13:48:35 ******/
