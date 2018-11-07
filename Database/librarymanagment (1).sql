-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2017 at 09:12 AM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 7.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `librarymanagment`
--

-- --------------------------------------------------------

--
-- Table structure for table `booklentouttable`
--

CREATE TABLE `booklentouttable` (
  `borrowcode` varchar(10) NOT NULL,
  `bookcode` varchar(20) NOT NULL,
  `stdcardid` varchar(20) NOT NULL,
  `name` varchar(20) NOT NULL,
  `issuedate` varchar(20) NOT NULL,
  `returndate` varchar(20) NOT NULL,
  `returnstatus` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `booklentouttable`
--

INSERT INTO `booklentouttable` (`borrowcode`, `bookcode`, `stdcardid`, `name`, `issuedate`, `returndate`, `returnstatus`) VALUES
('123', '', '', '', 'Friday, May 12, 2017', 'Friday, May 12, 2017', 'not returned');

-- --------------------------------------------------------

--
-- Table structure for table `bookstable`
--

CREATE TABLE `bookstable` (
  `code` int(20) NOT NULL,
  `name` varchar(20) NOT NULL,
  `subject` varchar(20) NOT NULL,
  `author` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `librariantable`
--

CREATE TABLE `librariantable` (
  `L_ID` varchar(20) NOT NULL,
  `L_Name` varchar(20) NOT NULL,
  `Branch` varchar(20) NOT NULL,
  `Contact` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `librariantable`
--

INSERT INTO `librariantable` (`L_ID`, `L_Name`, `Branch`, `Contact`, `Password`) VALUES
('1', 'dredd', 'kla', '2566', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `studentstable`
--

CREATE TABLE `studentstable` (
  `librarycard_id` varchar(20) NOT NULL,
  `reg_id` varchar(20) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `class` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `booklentouttable`
--
ALTER TABLE `booklentouttable`
  ADD PRIMARY KEY (`borrowcode`);

--
-- Indexes for table `librariantable`
--
ALTER TABLE `librariantable`
  ADD PRIMARY KEY (`L_ID`);

--
-- Indexes for table `studentstable`
--
ALTER TABLE `studentstable`
  ADD PRIMARY KEY (`librarycard_id`),
  ADD UNIQUE KEY `reg_id` (`reg_id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
