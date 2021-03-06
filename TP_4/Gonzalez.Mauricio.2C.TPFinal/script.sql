USE [master]
GO
/****** Object:  Database [TP4_DB]    Script Date: 6/18/2022 11:41:07 AM ******/
CREATE DATABASE [TP4_DB]
 CONTAINMENT = NONE
ALTER DATABASE [TP4_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [TP4_DB] SET  MULTI_USER 
GO
ALTER DATABASE [TP4_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP4_DB', N'ON'
GO
ALTER DATABASE [TP4_DB] SET QUERY_STORE = OFF
GO
USE [TP4_DB]
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 6/18/2022 11:41:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libros](
	[nombre] [varchar](50) NOT NULL,
	[autor] [varchar](50) NOT NULL,
	[categoria] [varchar](50) NOT NULL,
	[stock] [int] NOT NULL,
	[precio] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reclamos]    Script Date: 6/18/2022 11:41:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reclamos](
	[Tipo] [varchar](50) NOT NULL,
	[Libro] [varchar](50) NOT NULL,
	[Cliente] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Rhea americana', N'Lem Patington', N'3', 7, 63.85)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Elephas maximus bengalensis', N'Merry Northley', N'2', 6, 92.82)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Cervus elaphus', N'Rickey Marshal', N'3', 5, 5.23)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Genetta genetta', N'Trish Bruhn', N'3', 1, 61.92)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Sarcophilus harrisii', N'Laina Berkeley', N'3', 4, 76.74)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Theropithecus gelada', N'Isahella HinStock', N'0', 3, 68.01)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Macaca mulatta', N'Matthiew Allott', N'3', 6, 49.42)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Uraeginthus granatina', N'Veronika Fulleylove', N'2', 10, 70)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Laniaurius atrococcineus', N'Noland Hallybone', N'2', 5, 55.07)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Bassariscus astutus', N'Saidee Bullen', N'3', 2, 13.57)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Grus canadensis', N'Tory Manicomb', N'4', 1, 4.89)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Antechinus flavipes', N'Rafferty Van Hesteren', N'2', 6, 32.9)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Canis mesomelas', N'Quill McAline', N'3', 7, 52.97)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Tamiasciurus hudsonicus', N'Cristie Santen', N'0', 9, 65.63)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Corvus albicollis', N'Aggy Coster', N'3', 10, 60.18)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Bucorvus leadbeateri', N'Renee Dorrington', N'2', 10, 62.38)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Ateles paniscus', N'Aubine MacFaul', N'2', 7, 66.49)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Sceloporus magister', N'Bab Scholey', N'2', 3, 36.74)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Dusicyon thous', N'Say Barok', N'1', 3, 15.5)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Loris tardigratus', N'Cyrillus Rhule', N'4', 4, 93.74)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Dendrocitta vagabunda', N'Thomasina Pyle', N'3', 2, 6.38)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Haliaetus leucogaster', N'Calley Tezure', N'4', 8, 23.01)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Eolophus roseicapillus', N'Ariana Vogel', N'3', 3, 34.5)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Pycnonotus barbatus', N'Bobbee Creaser', N'2', 4, 56.99)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Cacatua tenuirostris', N'Kaine Revill', N'2', 3, 65.15)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Procyon cancrivorus', N'Lorrin Reyburn', N'2', 3, 7.48)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Agama sp.', N'Auberta Budnk', N'4', 9, 57.64)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Myrmecobius fasciatus', N'Nickolas McIlvaney', N'0', 5, 91.2)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Larus sp.', N'Faith Kitchingman', N'3', 1, 59.66)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Marmota caligata', N'Tiler O''Corr', N'1', 3, 66)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Plectopterus gambensis', N'Moise Vile', N'2', 9, 87.96)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Phoenicopterus ruber', N'Irvin McCumskay', N'0', 1, 33.06)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'unavailable', N'Danie Raspin', N'2', 8, 81.27)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Diceros bicornis', N'Morly Masedon', N'0', 9, 49.91)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Panthera pardus', N'Emili Jouannin', N'2', 4, 33.83)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Felis concolor', N'Wynnie Flacknoe', N'2', 10, 57.79)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Morelia spilotes variegata', N'Marv Bravington', N'0', 5, 43.35)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Macropus fuliginosus', N'Sonny de Leon', N'2', 9, 42.95)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Graspus graspus', N'Ingrid McBratney', N'4', 3, 3.9)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Picoides pubescens', N'Zola Proudlove', N'3', 5, 54.47)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Cordylus giganteus', N'Brennen de Verson', N'2', 7, 30.33)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Boa constrictor mexicana', N'Calley Close', N'1', 9, 13.91)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Cebus apella', N'Elene Tarbet', N'1', 9, 11.04)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Pelecanus conspicillatus', N'Richmound Rizzo', N'4', 7, 69.63)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Phalacrocorax niger', N'Clementius Phaup', N'1', 2, 43.93)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Choloepus hoffmani', N'Syd Skelly', N'1', 5, 33.13)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Anthropoides paradisea', N'Xymenes Deignan', N'0', 7, 30.48)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Damaliscus dorcas', N'Dasie Goudie', N'4', 9, 17.69)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Phalacrocorax albiventer', N'Cristen Ricketts', N'3', 7, 58.24)
INSERT [dbo].[Libros] ([nombre], [autor], [categoria], [stock], [precio]) VALUES (N'Crax sp.', N'Demetris Labern', N'0', 4, 84.83)
GO
INSERT [dbo].[Reclamos] ([Tipo], [Libro], [Cliente]) VALUES (N'0', N'Rhea americana', N'Reamonn')
INSERT [dbo].[Reclamos] ([Tipo], [Libro], [Cliente]) VALUES (N'1', N'Cervus elaphus', N'Gunar')
GO
USE [master]
GO
ALTER DATABASE [TP4_DB] SET  READ_WRITE 
GO
