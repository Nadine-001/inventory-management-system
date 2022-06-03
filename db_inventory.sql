-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 03, 2022 at 04:46 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.4.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblautonumber`
--

CREATE TABLE `tblautonumber` (
  `ID` int(11) NOT NULL,
  `STRT` varchar(30) NOT NULL,
  `END` varchar(30) NOT NULL,
  `INCREMENT` int(11) NOT NULL,
  `DESCRIPTION` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblautonumber`
--

INSERT INTO `tblautonumber` (`ID`, `STRT`, `END`, `INCREMENT`, `DESCRIPTION`) VALUES
(1, '00001', '15', 1, 'Customer'),
(2, '20122', '8', 1, 'Supplier'),
(3, '32302', '16', 1, 'StockIn'),
(4, '102201', '19', 1, 'StockOut'),
(5, '53132', '25', 1, 'StockReturn'),
(6, '0000', '7', 1, 'ItemID'),
(7, 'P0000', '10', 1, 'PET'),
(8, 'M0000', '22', 1, 'MEDICINE'),
(9, 'F0000', '39', 1, 'FOOD'),
(10, 'D0000', '24', 1, 'DRINK'),
(11, 'S0000', '24', 1, 'SKINCARE'),
(12, 'O0000', '50', 1, 'OTHER');

-- --------------------------------------------------------

--
-- Table structure for table `tblitems`
--

CREATE TABLE `tblitems` (
  `ITEMID` varchar(30) NOT NULL,
  `NAME` varchar(90) NOT NULL,
  `DESCRIPTION` varchar(90) NOT NULL,
  `TYPE` varchar(30) NOT NULL,
  `PRICE` double NOT NULL,
  `QTY` int(11) NOT NULL,
  `UNIT` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblitems`
--

INSERT INTO `tblitems` (`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`, `QTY`, `UNIT`) VALUES
('D000019', 'Cola Cola', 'Soda', 'DRINK', 48000, 23, 'box'),
('D000020', 'Milk \"Indosusu\"', 'UHT Milk', 'DRINK', 90000, 65, 'box'),
('D000021', 'Vitamin C Drink \"Cx\"', 'Vitamin Drink', 'DRINK', 300000, 14, 'box'),
('D000022', 'Coffee \"Great Day\"', 'Coffee', 'DRINK', 65000, 34, 'box'),
('D000023', 'Tea \"My Sisro\"', 'Tea', 'DRINK', 50000, 11, 'box'),
('F000033', 'Mie Instan \"Imdonie\"', 'Instant Food', 'FOOD', 83000, 55, 'box'),
('F000034', 'Mie Instan \"Mie Enak\"', 'Instant Food', 'FOOD', 85000, 50, 'box'),
('F000035', 'Bubur \"Bubur Super\"', 'Instant Food', 'FOOD', 53000, 36, 'box'),
('F000036', 'Cracker \"Mallist\"', 'Snack', 'FOOD', 45000, 45, 'box'),
('F000037', 'Sandwich \"Mr. Bun\"', 'Bread', 'FOOD', 48000, 39, 'box'),
('F000038', 'Oat Milk \"Energyne\"', 'Sereal', 'FOOD', 35000, 97, 'pcs.'),
('M000016', 'Vitamin C \"C500\"', 'Vitamin Pil', 'MEDICINE', 25000, 25, 'box'),
('M000017', 'Plester \"Handplest\"', 'Plester', 'MEDICINE', 30000, 6, 'box'),
('M000018', 'Headache Medicine \"Lanadop\"', 'Pil Medicine', 'MEDICINE', 10500, 62, 'pcs.'),
('M000019', 'Fever Medicine \"Ensana\"', 'Pil Medicine', 'MEDICINE', 22000, 8, 'box'),
('M000020', 'Cough Medicine \"Bydrex\"', 'Syrup Medicine', 'MEDICINE', 2000, 50, 'pcs.'),
('M000021', 'Flu Medicine \"Cometz\"', 'Syrup Medicine', 'MEDICINE', 35000, 13, 'box'),
('O000043', 'Sanitary Napkin \"Lauyer\"', 'Sanitary Napkin', 'OTHER', 123000, 45, 'box'),
('O000044', 'Diaper \"Mommy Paka\"', 'Diaper', 'OTHER', 195000, 47, 'box'),
('O000045', 'Mosquito Spray \"Bygen\"', 'Insect Spray', 'OTHER', 29000, 48, 'pcs.'),
('O000046', 'Floor Cleaner \"Zipol\"', 'Carbolic Floor Cleaner', 'OTHER', 5000, 1000, 'pcs.'),
('O000047', 'Dish Soap \"Mother Lemon\"', 'Dish Soap', 'OTHER', 63000, 50, 'box'),
('O000048', 'Toilet Cleaner \"Jarpix\"', 'Toilet Cleaner', 'OTHER', 19000, 54, 'pcs.'),
('O000049', 'Parfume \"Pitalis\"', 'Girls Parfume', 'OTHER', 35000, 9, 'pcs.'),
('P00005', 'Cat Food \"Whisey\"', 'Pet Food', 'PET', 50000, 8, 'pcs.'),
('P00006', 'Dog Food \"Caesar\"', 'Pet Food', 'PET', 55000, 10, 'pcs.'),
('P00007', 'Multivitamin \"My Cat\"', 'Pet Vitamin', 'PET', 20000, 7, 'pcs.'),
('P00008', 'Milk \"Lovely Cat\"', 'Pet Food', 'PET', 14500, 59, 'pcs.'),
('P00009', 'Milk \"Beloved Doggy\"', 'Pet Food', 'PET', 20000, 52, 'pcs.'),
('S000021', 'Lip Scrub \"Emana\"', 'Lip Scrub', 'SKINCARE', 28000, 60, 'pcs.'),
('S000022', 'Green Tea Mask \"Garyier\"', 'Beauty Mask', 'SKINCARE', 18000, 95, 'pcs.'),
('S000023', 'Anti Acne Face Wash \"Mustika Putri\"', 'Face Wash', 'SKINCARE', 17000, 100, 'pcs.');

-- --------------------------------------------------------

--
-- Table structure for table `tblperson`
--

CREATE TABLE `tblperson` (
  `ID` int(11) NOT NULL,
  `SUPLIERCUSTOMERID` varchar(90) DEFAULT NULL,
  `FIRSTNAME` varchar(90) DEFAULT NULL,
  `LASTNAME` varchar(90) DEFAULT NULL,
  `ADDRESS` varchar(90) DEFAULT NULL,
  `TELEPHONE` varchar(30) DEFAULT NULL,
  `MOBILE` varchar(30) DEFAULT NULL,
  `TYPE` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblperson`
--

INSERT INTO `tblperson` (`ID`, `SUPLIERCUSTOMERID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`) VALUES
(4, '000011', 'Sulistyo', 'Pandu', 'Jl. Pemuda', '0249990', '089091122215', 'Customer'),
(5, '000013', 'Kemal', 'Hanafi', 'Jl. Sriwijaya', '0246211', '087483322547', 'Customer'),
(7, '000015', 'Lionita', 'Melati', 'Jl. Cilosari Barat', '', '083489752666', 'Customer'),
(8, '000016', 'Abyan', 'Ardiatama', 'Jl. Majapahit', '0244402', '085485743184', 'Customer'),
(9, '000019', 'Difva', 'Maura', 'Jl. Sawi', '0241185', '085295596065', 'Customer'),
(10, '0000110', 'Daffa', 'Adhimas', 'Jl. Sendang Mulya', '', '089085511125', 'Customer'),
(11, '0000111', 'Annes', 'Vidya', 'Jl. Klipang', '', '08956775433', 'Customer'),
(12, '0000112', 'Afifah', 'Nurul', 'Jl. Sisingamangaraja', '', '081123456675', 'Customer'),
(13, '0000113', 'Lintang', 'Ayu', 'Jl. Wonodri Kopen', '0243601', '087095544124', 'Customer'),
(14, '0000114', 'Aditya', 'Nugraha', 'Jl. Cinde Raya', '', '083109000721', 'Customer');

-- --------------------------------------------------------

--
-- Table structure for table `tblsettings`
--

CREATE TABLE `tblsettings` (
  `ID` int(11) NOT NULL,
  `DESCRIPTION` text NOT NULL,
  `PARA` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsettings`
--

INSERT INTO `tblsettings` (`ID`, `DESCRIPTION`, `PARA`) VALUES
(2, 'pcs.', 'Unit'),
(3, 'box', 'Unit'),
(6, 'DRINK', 'Category'),
(7, 'FOOD', 'Category'),
(8, 'SKINCARE', 'Category'),
(9, 'MEDICINE', 'Category'),
(10, 'PET', 'Category'),
(11, 'OTHER', 'Category');

-- --------------------------------------------------------

--
-- Table structure for table `tblstock_in_out`
--

CREATE TABLE `tblstock_in_out` (
  `STOCKOUTID` int(11) NOT NULL,
  `TRANSACTIONNUMBER` varchar(30) NOT NULL,
  `ITEMID` varchar(30) NOT NULL,
  `TRANSACTIONDATE` date NOT NULL,
  `QTY` int(11) NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `SUPLIERCUSTOMERID` varchar(30) NOT NULL,
  `REMARKS` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstock_in_out`
--

INSERT INTO `tblstock_in_out` (`STOCKOUTID`, `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `QTY`, `TOTALPRICE`, `SUPLIERCUSTOMERID`, `REMARKS`) VALUES
(1, '', 'M000019', '2021-08-25', 5, 100000, '', 'StockIn'),
(2, '4908731', 'P00007', '2021-08-25', 5, 100000, '0000112', 'StockOut'),
(3, '', 'M000017', '2021-08-25', 10, 250000, '', 'StockIn'),
(4, '', 'M000019', '2021-08-25', 50, 2000, '', 'StockIn'),
(5, '', 'D000020', '2021-08-25', 25, 2200000, '', 'StockIn'),
(6, '', 'F000033', '2021-08-25', 15, 1100000, '', 'StockIn'),
(7, '', 'M000018', '2021-08-25', 40, 400000, '', 'StockIn'),
(8, '', 'O000043', '2021-08-25', 10, 1100000, '', 'StockIn'),
(9, '', 'O000044', '2021-08-25', 10, 1800000, '', 'StockIn'),
(10, '1022011', 'F000037', '2021-08-25', 5, 60000, '000011', 'StockOut'),
(11, '1022014', 'F000034', '2021-08-25', 5, 25000, '0000112', 'StockOut'),
(12, '1022019', 'S000023', '2021-08-26', 1, 17000, '0000110', 'StockOut'),
(13, '10220110', 'O000045', '2021-08-26', 1, 29000, '000019', 'StockOut'),
(14, '', 'F000038', '2021-08-26', 20, 630000, '', 'StockIn'),
(15, '10220111', 'M000018', '2021-08-26', 2, 21000, '000011', 'StockOut'),
(16, '10220114', 'D000020', '2021-08-26', 4, 24000, '0000113', 'StockOut'),
(17, '10220115', 'M000016', '2021-08-26', 6, 18000, '0000111', 'StockOut'),
(18, '10220116', 'F000033', '2021-08-26', 5, 40000, '0000112', 'StockOut'),
(19, '', 'P00006', '2021-08-27', 10, 500000, '', 'StockIn'),
(20, '', 'D000023', '2021-08-27', 20, 990000, '', 'StockIn'),
(21, '', 'D000021', '2021-08-27', 170, 25, '7000000', 'StockIn'),
(22, '', 'D000019', '2021-08-27', 30, 1000000, '', 'StockIn'),
(23, '10220117', 'F000035', '2021-08-27', 4, -33000, '0000112', 'StockOut'),
(24, '10220118', 'F000037', '2021-08-28', 1, 12000, '000016', 'StockOut'),
(25, '5313223', 'D000019', '2021-08-28', 1, 5000, '000011', 'StockOut'),
(26, '5313223', 'O000043', '2021-08-28', 1, 20000, '000011', 'StockOut'),
(70, '', 'P00008', '2021-08-27', 60, 14500, '', 'StockIn'),
(71, '', 'P00009', '2021-08-27', 52, 20000, '', 'StockIn'),
(72, '5313224', 'P00008', '2021-08-27', 1, 14500, '0000113', 'StockOut'),
(73, '5313224', 'M000019', '2021-08-27', 1, 2000, '0000113', 'StockOut'),
(74, '5313224', 'F000037', '2021-08-27', 1, 8000, '0000113', 'StockOut');

-- --------------------------------------------------------

--
-- Table structure for table `tblstock_return`
--

CREATE TABLE `tblstock_return` (
  `STOCKRETURNID` int(11) NOT NULL,
  `STOCKRETURNNUMBER` varchar(30) NOT NULL,
  `ITEMID` varchar(30) NOT NULL,
  `RETURNDATE` date NOT NULL,
  `QTY` int(11) NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `OWNER_CUS_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstock_return`
--

INSERT INTO `tblstock_return` (`STOCKRETURNID`, `STOCKRETURNNUMBER`, `ITEMID`, `RETURNDATE`, `QTY`, `TOTALPRICE`, `OWNER_CUS_ID`) VALUES
(1, '5313217', 'D000021', '2021-08-25', 3, 9000, 11),
(2, '5313218', 'F000034', '2021-08-26', 3, 15000, 110),
(3, '5313219', 'F000038', '2021-08-26', 1, 5000, 19),
(4, '5313220', 'F000034', '2021-08-27', 3, 15000, 13),
(5, '5313221', 'M000017', '2021-08-27', 1, 2500, 112),
(6, '5313222', 'M000017', '2021-08-28', 2, 5000, 11),
(7, '6', 'F000035', '2021-08-27', 1, 53000, 112);

-- --------------------------------------------------------

--
-- Table structure for table `tblsuplier`
--

CREATE TABLE `tblsuplier` (
  `ID` int(11) NOT NULL,
  `SUPLIERID` varchar(90) DEFAULT NULL,
  `FIRSTNAME` varchar(90) DEFAULT NULL,
  `LASTNAME` varchar(90) DEFAULT NULL,
  `ADDRESS` varchar(90) DEFAULT NULL,
  `TELEPHONE` varchar(30) DEFAULT NULL,
  `MOBILE` varchar(30) DEFAULT NULL,
  `TYPE` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsuplier`
--

INSERT INTO `tblsuplier` (`ID`, `SUPLIERID`, `FIRSTNAME`, `LASTNAME`, `ADDRESS`, `TELEPHONE`, `MOBILE`, `TYPE`) VALUES
(5, '20180119', 'Hendrian', 'Setya', 'Jl. Panda Utara I', '0241145', '09496585632', 'SUPPLIER');

-- --------------------------------------------------------

--
-- Table structure for table `tbltransaction`
--

CREATE TABLE `tbltransaction` (
  `STOCKINID` int(11) NOT NULL,
  `TRANSACTIONNUMBER` varchar(30) DEFAULT NULL,
  `TRANSACTIONDATE` date NOT NULL,
  `TYPE` varchar(30) NOT NULL,
  `SUPLIERCUSTOMERID` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbltransaction`
--

INSERT INTO `tbltransaction` (`STOCKINID`, `TRANSACTIONNUMBER`, `TRANSACTIONDATE`, `TYPE`, `SUPLIERCUSTOMERID`) VALUES
(1, '4908731', '2021-08-25', 'StockOut', '000019'),
(2, '1022011', '2021-08-25', 'StockOut', '000011'),
(3, '4908731', '2021-08-25', 'Returned', '000019'),
(7, '1022012', '2021-08-25', 'StockOut', '0000114'),
(9, '1022013', '2021-08-25', 'StockOut', '000011'),
(10, '1022014', '2021-08-25', 'StockOut', '000013'),
(11, '1022015', '2021-08-25', 'StockOut', '000011'),
(12, '1022016', '2021-08-25', 'StockOut', '000016'),
(13, '1022017', '2021-08-26', 'StockOut', '000016'),
(14, '1022018', '2021-08-26', 'StockOut', '000013'),
(15, '1022019', '2021-08-26', 'StockOut', '0000110'),
(16, '1022019', '2021-08-26', 'Returned', '0000110'),
(17, '10220110', '2021-08-26', 'StockOut', '000019'),
(18, '10220110', '2021-08-26', 'Returned', '000013'),
(19, '10220111', '2021-08-26', 'StockOut', '000011'),
(20, '10220112', '2021-08-26', 'StockOut', '000013'),
(21, '10220112', '2021-08-26', 'Returned', '000013'),
(22, '10220113', '2021-08-26', 'StockOut', '0000112'),
(23, '10220114', '2021-08-26', 'StockOut', '0000113'),
(24, '10220115', '2021-08-26', 'StockOut', '0000111'),
(25, '10220116', '2021-08-26', 'StockOut', '0000112'),
(26, '10220117', '2021-08-27', 'StockOut', '0000112'),
(27, '10220117', '2021-08-27', 'Returned', '0000111'),
(28, '10220118', '2021-08-27', 'StockOut', '000016'),
(29, '10220111', '2021-08-28', 'Returned', '0000113'),
(30, '5313223', '2021-08-28', 'StockOut', '000011'),
(31, '5313224', '2021-08-27', 'StockOut', '0000113'),
(32, '10220117', '2021-08-27', 'Returned', '112');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `user_id` int(11) NOT NULL,
  `name` varchar(90) DEFAULT NULL,
  `user_name` varchar(90) DEFAULT NULL,
  `pass` varchar(90) DEFAULT NULL,
  `type` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`user_id`, `name`, `user_name`, `pass`, `type`) VALUES
(2, 'nadine', 'nana', 'dc28119d07b55c33ce29aa11b1f1eccdf6751f83', 'Administrator'),
(13, 'Admin', 'admin', 'f865b53623b121fd34ee5426c792e5c33af8c227', 'Administrator'),
(12, 'Staff', 'staff', '5d43e3169f06cf2a04a0ee870b5ac2aff3c558ff', 'Staff');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblitems`
--
ALTER TABLE `tblitems`
  ADD PRIMARY KEY (`ITEMID`);

--
-- Indexes for table `tblperson`
--
ALTER TABLE `tblperson`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `CUSID` (`SUPLIERCUSTOMERID`);

--
-- Indexes for table `tblsettings`
--
ALTER TABLE `tblsettings`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblstock_in_out`
--
ALTER TABLE `tblstock_in_out`
  ADD PRIMARY KEY (`STOCKOUTID`);

--
-- Indexes for table `tblstock_return`
--
ALTER TABLE `tblstock_return`
  ADD PRIMARY KEY (`STOCKRETURNID`);

--
-- Indexes for table `tblsuplier`
--
ALTER TABLE `tblsuplier`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `SUPID` (`SUPLIERID`);

--
-- Indexes for table `tbltransaction`
--
ALTER TABLE `tbltransaction`
  ADD PRIMARY KEY (`STOCKINID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblautonumber`
--
ALTER TABLE `tblautonumber`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `tblperson`
--
ALTER TABLE `tblperson`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tblsettings`
--
ALTER TABLE `tblsettings`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tblstock_in_out`
--
ALTER TABLE `tblstock_in_out`
  MODIFY `STOCKOUTID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=75;

--
-- AUTO_INCREMENT for table `tblstock_return`
--
ALTER TABLE `tblstock_return`
  MODIFY `STOCKRETURNID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tblsuplier`
--
ALTER TABLE `tblsuplier`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbltransaction`
--
ALTER TABLE `tbltransaction`
  MODIFY `STOCKINID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
