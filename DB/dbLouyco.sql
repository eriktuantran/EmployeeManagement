-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: localhost
-- Thời gian đã tạo: Th7 04, 2019 lúc 11:32 PM
-- Phiên bản máy phục vụ: 5.5.57
-- Phiên bản PHP: 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


DROP DATABASE IF EXISTS dbLouyco;
CREATE DATABASE IF NOT EXISTS dbLouyco;
USE dbLouyco;

SELECT 'CREATING DATABASE STRUCTURE' as 'INFO';

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `dbLouyco`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `bophan`
--

CREATE TABLE `bophan` (
  `id` int(10) UNSIGNED NOT NULL,
  `name` varchar(512) NOT NULL,
  `parent` int(10) UNSIGNED DEFAULT '0',
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Đang đổ dữ liệu cho bảng `bophan`
--

INSERT INTO `bophan` (`id`, `name`, `parent`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'Khối văn phòng, quản lý', 0, NULL, NULL, NULL),
(2, 'Khối Sản xuất, vận hành', 0, NULL, NULL, NULL),
(3, 'Kinh doanh', 1, NULL, NULL, NULL),
(4, 'Kế toán', 1, NULL, NULL, NULL),
(5, 'Marketing', 1, NULL, NULL, NULL),
(6, 'Hành chính quản trị', 1, NULL, NULL, NULL),
(7, 'Quản lý chất lượng', 1, NULL, NULL, NULL),
(8, 'Thu mua', 1, NULL, NULL, NULL),
(9, 'Vật tư', 1, NULL, NULL, NULL),
(10, 'Điều hành sản xuất', 1, NULL, NULL, NULL),
(11, 'Phân xưởng có điện', 2, NULL, NULL, NULL),
(12, 'Phân xưởng SX', 2, NULL, NULL, NULL),
(13, 'Chuẩn bị bao bì', 2, NULL, NULL, NULL),
(14, 'Quản lý KCS', 12, NULL, NULL, NULL),
(15, 'Bốc vác', 12, NULL, NULL, NULL),
(16, 'Nguyên liệu', 12, NULL, NULL, NULL),
(17, 'Tổ rửa', 12, NULL, NULL, NULL),
(18, 'Đứng bồn', 12, NULL, NULL, NULL),
(19, 'Chuyền 1-7', 12, NULL, NULL, NULL),
(20, 'IQF', 12, NULL, NULL, NULL),
(21, 'Đông gió', 12, NULL, NULL, NULL),
(22, 'Thành phẩm', 12, NULL, NULL, NULL),
(23, 'Đóng thùng', 12, NULL, NULL, NULL),
(24, 'Kho', 12, NULL, NULL, NULL),
(25, 'Phòng giặt', 2, NULL, NULL, NULL),
(26, 'Bếp', 2, NULL, NULL, NULL),
(27, 'Tạp vụ', 2, NULL, NULL, NULL),
(28, 'Bảo vệ', 2, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `ca`
--

CREATE TABLE `ca` (
  `id` int(10) UNSIGNED NOT NULL,
  `name` varchar(255) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Đang đổ dữ liệu cho bảng `ca`
--

INSERT INTO `ca` (`id`, `name`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'Ca 1', NULL, NULL, NULL),
(2, 'Ca 2', NULL, NULL, NULL),
(3, 'Ca 3', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `checkin`
--

CREATE TABLE `checkin` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `emp_no` varchar(11) NOT NULL,
  `date` datetime DEFAULT NULL,
  `checkin` timestamp NULL DEFAULT NULL,
  `checkout` timestamp NULL DEFAULT NULL,
  `pic1` varchar(512) DEFAULT NULL,
  `pic2` varchar(512) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `company`
--

CREATE TABLE `company` (
  `id` int(10) UNSIGNED NOT NULL,
  `name` varchar(512) NOT NULL,
  `address` varchar(1024) NOT NULL,
  `masothue` varchar(30) NOT NULL,
  `phone` varchar(30) NOT NULL,
  `fax` varchar(30) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Đang đổ dữ liệu cho bảng `company`
--

INSERT INTO `company` (`id`, `name`, `address`, `masothue`, `phone`, `fax`, `created_at`, `updated_at`) VALUES
(1, 'CÔNG TY TNHH TƯ VẤN THƯƠNG MẠI DỊCH VỤ KỸ THUẬT HƯNG PHÁT', '22/14 Đường 18D, Khu Phố 10, Phường Bình Hưng Hòa A, Q. Bình Tân, Tp. HCM', '0312378319', '08 62664728', '08 62664728', NULL, NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `employees`
--

CREATE TABLE `employees` (
  `emp_no` varchar(11) NOT NULL,
  `birth_date` date DEFAULT NULL,
  `first_name` varchar(30) NOT NULL,
  `last_name` varchar(30) NOT NULL,
  `bo_phan` varchar(255) NOT NULL,
  `bophan_id` int(10) UNSIGNED DEFAULT NULL,
  `loai_hd` varchar(255) NOT NULL,
  `gender` enum('M','F') DEFAULT NULL,
  `hire_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Đang đổ dữ liệu cho bảng `employees`
--

INSERT INTO `employees` (`emp_no`, `birth_date`, `first_name`, `last_name`, `bo_phan`, `bophan_id`, `loai_hd`, `gender`, `hire_date`) VALUES
('100003', NULL, 'Ánh', 'Nguyễn Thị ', 'LINE-2', NULL, 'LĐ DH', NULL, NULL),
('100005', NULL, 'Bảo', 'Nguyễn Viết', 'VP', NULL, 'LĐ DH', NULL, NULL),
('100011', NULL, 'Chi', 'Văn Thị Phương', 'TT', NULL, 'LĐ DH', NULL, NULL),
('100012', NULL, 'Chí', 'Mai Văn Minh', 'VP', NULL, 'LĐ DH', NULL, NULL),
('100014', NULL, 'Chính', 'Nguyễn Thị ', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100015', NULL, 'Công', 'Huỳnh Thị ', 'LINE-2', NULL, 'LĐ DH', NULL, NULL),
('100019', NULL, 'Dũng', 'Lê Hoàng Tuấn', 'VP', NULL, 'LĐ DH', NULL, NULL),
('100020', NULL, 'Diệu', 'Ngô Thị', 'TV-N', NULL, 'LĐ DH', NULL, NULL),
('100021', NULL, 'Đèo', 'Nguyễn Thị', 'LINE-4', NULL, 'LĐ DH', NULL, NULL),
('100024', NULL, 'Dung', 'Phan Thị ', 'LINE-2', NULL, 'LĐ DH', NULL, NULL),
('100031', NULL, 'Diễm', 'Võ Thị Ngọc ', 'LINE-3', NULL, 'THỜI VỤ', NULL, NULL),
('100032', NULL, 'Giang', 'Cao Văn', 'P.V-1', NULL, 'LĐ DH', NULL, NULL),
('100035', NULL, 'Hà', 'Vũ Thị ', 'VP', NULL, 'LĐ DH', NULL, NULL),
('100039', NULL, 'Hạnh', 'Phan Ngọc ', 'VP', NULL, 'LĐ DH', NULL, NULL),
('100040', NULL, 'Hậu', 'Nguyễn Phạm Mai', 'P.V-3', NULL, 'LĐ DH', NULL, NULL),
('100044', NULL, 'Hoàng', 'Phạm Trần Thị', 'VP', NULL, 'LĐ DH', NULL, NULL),
('100047', NULL, 'Hợp', 'Võ Thị ', 'BB', NULL, 'LĐ DH', NULL, NULL),
('100050', NULL, 'Hương', 'Nguyễn Thị Kim', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('100052', NULL, 'Hương', 'Nguyễn Thị Ngọc ', 'TT', NULL, 'LĐ DH', NULL, NULL),
('100053', NULL, 'Hương', 'Nguyễn Thị', 'TV-B', NULL, 'LĐ DH', NULL, NULL),
('100055', NULL, 'Huyền', 'Dương Thị ', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100057', NULL, 'Khoa', 'Mai Văn Minh', 'P.V-3', NULL, 'LĐ DH', NULL, NULL),
('100061', NULL, 'Lài', 'Nguyễn Thị ', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100065', NULL, 'Lan', 'Nguyễn Văn ', 'P.V-3', NULL, 'LĐ DH', NULL, NULL),
('100067', NULL, 'Liên', 'Ngô Thị Phượng', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100070', NULL, ' Loan', 'Nguyễn Thị Hồng', 'TT', NULL, 'LĐ DH', NULL, NULL),
('100075', NULL, 'Mẫn', 'Mai Minh', 'CA TRƯỞNG', NULL, 'LĐ DH', NULL, NULL),
('100080', NULL, 'Mỹ', 'Huỳnh Thị ', 'LINE-4', NULL, 'LĐ DH', NULL, NULL),
('100083', NULL, 'Nga', 'Trần Thị ', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100088', NULL, 'Nhiều', 'Nguyễn Thị ', 'LINE-4', NULL, 'THỜI VỤ', NULL, NULL),
('100090', NULL, 'Nhung', 'Nguyễn Thị ', 'LINE-4', NULL, 'LĐ DH', NULL, NULL),
('100091', NULL, 'Nhung', 'Phạm Thị Bích', 'LINE-4', NULL, 'LĐ DH', NULL, NULL),
('100094', NULL, 'Nữ', 'Phạm Chí ', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100097', NULL, 'Ơn', 'Thạch', 'P.V-3', NULL, 'LĐ DH', NULL, NULL),
('100098', NULL, 'Phụng', 'Lê Minh ', 'ĐT', NULL, 'LĐ DH', NULL, NULL),
('100103', NULL, 'Phương', 'Nguyễn Thị Thu ', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('100104', NULL, ' Phương', 'Trần Thị Thanh ', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('100108', NULL, 'Phượng', 'Nguyễn Thị Thu ', 'TT', NULL, 'LĐ DH', NULL, NULL),
('100110', NULL, 'Quân', 'Trần Thanh', 'VP', NULL, 'LĐ DH', NULL, NULL),
('100116', NULL, 'Sen', 'Nguyễn Thị', 'ỐM-TS', NULL, 'LĐ DH', NULL, NULL),
('100118', NULL, 'Tài', 'Ngô Văn ', 'VP', NULL, 'THỜI VỤ', NULL, NULL),
('100125', NULL, 'Thảo', 'Võ Thị Thanh', 'TT', NULL, 'LĐ DH', NULL, NULL),
('100131', NULL, 'Thịnh', 'Nguyễn Hoài', 'ĐT', NULL, 'LĐ DH', NULL, NULL),
('100133', NULL, 'Thon', 'Nguyễn Thị ', 'TV-B', NULL, 'LĐ DH', NULL, NULL),
('100134', NULL, 'Thu', 'Lê Thị ', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100140', NULL, 'Tổng', 'Võ Công', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('100141', NULL, 'Tốt', 'Nguyễn Thị', 'TV-B', NULL, 'LĐ DH', NULL, NULL),
('100145', NULL, 'Trung', 'Thái Phạm', 'ĐB', NULL, 'LĐ DH', NULL, NULL),
('100149', NULL, 'Tuấn', 'Huỳnh Minh', 'P.V-3', NULL, 'LĐ DH', NULL, NULL),
('100151', NULL, 'Tuyến', 'Nguyễn Quang', 'VP', NULL, 'LĐ DH', NULL, NULL),
('100164', NULL, 'Yến', 'Nguyễn Thị Ngọc', 'VP', NULL, 'LĐ DH', NULL, NULL),
('100165', NULL, 'Yến', 'Châu Bảo', 'CA TRƯỞNG', NULL, 'LĐ DH', NULL, NULL),
('100172', NULL, 'Cường', 'Phan Phú', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('100173', NULL, 'Dung', 'Phan Phú Hạnh', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('100179', NULL, 'Hoàng', 'Thạch Thị ', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('100200', NULL, 'Anh', 'Nguyễn Thị Huỳnh ', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100206', NULL, 'Biết', 'Huỳnh Thị', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100215', NULL, 'Đào', 'Nguyễn Thị ', 'LINE-2', NULL, 'LĐ DH', NULL, NULL),
('100225', NULL, 'Hằng', 'Nguyễn Thị Ngọc', 'LINE-2', NULL, 'LĐ DH', NULL, NULL),
('100239', NULL, 'Kia', 'Nguyễn Thị', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100240', NULL, 'Kiều', 'Trần Thanh Phương ', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100260', NULL, 'Một', 'Nguyễn Thị', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100262', NULL, 'Nga', 'Nguyễn Thị Kiều ', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100265', NULL, 'Nguyên', 'Huỳnh Thị Ngọc ', 'LINE-2', NULL, 'LĐ DH', NULL, NULL),
('100268', NULL, 'Nhàn', 'Nguyễn Thị ', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100286', NULL, 'Phượng', 'Phạm Thị Kim', 'LINE-2', NULL, 'LĐ DH', NULL, NULL),
('100289', NULL, 'Sang', 'Nguyễn Thị ', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100290', NULL, 'Sáu', 'Nguyễn Thị', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100318', NULL, 'Tư', 'Nguyễn Thị', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('100329', NULL, 'Thu', 'Phạm Thị', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100371', NULL, 'Diễm', 'Nguyễn Kiều', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100378', NULL, 'Phượng', 'Đoàn Thanh', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100387', NULL, 'Phí', 'Lê Thị ', 'TV-X', NULL, 'LĐ DH', NULL, NULL),
('100397', NULL, 'Sáu', 'Nguyễn Văn', 'KHO LẠNH', NULL, 'LĐ DH', NULL, NULL),
('100403', NULL, 'Trang', 'Vương Thị Thu', 'P.G', NULL, 'LĐ DH', NULL, NULL),
('100424', NULL, 'Hai', 'Lê Thị', 'TP', NULL, 'LĐ DH', NULL, NULL),
('100426', NULL, 'Đẹp ', 'Nguyễn Thị', 'ĐG', NULL, 'LĐ DH', NULL, NULL),
('100432', NULL, 'Tuyền', 'Nguyễn Thị Mộng ', 'TT', NULL, 'LĐ DH', NULL, NULL),
('100440', NULL, 'Lắm', 'Trần Thị', 'LINE-4', NULL, 'LĐ DH', NULL, NULL),
('100449', NULL, 'Châu', 'Nguyễn Thị', 'LINE-2', NULL, 'LĐ DH', NULL, NULL),
('100450', NULL, 'Đẳng', 'Nguyễn Thị ', 'LINE-4', NULL, 'THỜI VỤ', NULL, NULL),
('100457', NULL, 'Huệ', 'Cao Thị', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100465', NULL, 'Kính', 'Trần Thị ', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100491', NULL, 'Phe', 'Nguyễn Thị ', 'ĐG', NULL, 'LĐ DH', NULL, NULL),
('100510', NULL, 'Phen', 'Nguyễn Thị', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100511', NULL, 'Hai', 'Lê Thị ', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100563', NULL, 'Tiến', 'Đặng Thị', 'ỐM-TS', NULL, 'LĐ DH', NULL, NULL),
('100566', NULL, 'Tép', 'Nguyễn Thị', 'LINE-4', NULL, 'LĐ DH', NULL, NULL),
('100569', NULL, 'Đào', 'Trần Thị', 'IQF', NULL, 'THỜI VỤ', NULL, NULL),
('100589', NULL, 'Phượng', 'Nguyễn Thị Kim ', 'LINE-5', NULL, 'THỜI VỤ', NULL, NULL),
('100597', NULL, 'Thủy', 'Trương Thanh ', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('100600', NULL, 'Khang', 'Thái Trường', 'ĐT', NULL, 'LĐ DH', NULL, NULL),
('100601', NULL, 'Thắm', 'Nguyễn Thị Kim ', 'ỐM-TS', NULL, 'LĐ DH', NULL, NULL),
('100602', NULL, 'Hương', 'Nguyễn Thị Ngọc', 'TV-N', NULL, 'THỜI VỤ', NULL, NULL),
('100622', NULL, 'Tư', 'Nguyễn Thị Bé', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100623', NULL, 'Vinh', 'Phạm Quang', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('100633', NULL, 'Trí', 'Lê Minh ', 'KHO LẠNH', NULL, 'LĐ DH', NULL, NULL),
('100679', NULL, 'Sương', 'Phạm Thị', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100681', NULL, 'Lệ', 'Trần Thị', 'LINE-2', NULL, 'LĐ DH', NULL, NULL),
('100682', NULL, 'Hai', 'Nguyễn Thị Bé', 'ĐG', NULL, 'LĐ DH', NULL, NULL),
('100714', NULL, 'Mến', 'Nguyễn Ngọc ', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('100740', NULL, 'Phượng', 'Cao Thị Thuý', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('100755', NULL, 'Ghị', 'Lê Thị', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('100771', NULL, 'Tiên', 'Văn Cẩm', 'ỐM-TS', NULL, 'LĐ DH', NULL, NULL),
('100773', NULL, 'Cảnh', 'Bùi Thị ', 'TP', NULL, 'LĐ DH', NULL, NULL),
('100838', NULL, 'Tâm', 'Bùi Hữu ', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('100950', NULL, 'Loan', 'Huỳnh Thị', 'TP', NULL, 'LĐ DH', NULL, NULL),
('100964', NULL, 'Khánh', 'Đỗ Lâm', 'CĐ', NULL, 'LĐ DH', NULL, NULL),
('100980', NULL, 'Sang', 'Huỳnh Tuấn ', 'TP', NULL, 'LĐ DH', NULL, NULL),
('100986', NULL, 'Thủy', 'Nguyễn Thị Lệ', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101026', NULL, 'Phượng', 'Lý Thị', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101029', NULL, 'Điểu', 'Trương Thị ', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('101088', NULL, 'Thảo', 'Ngô Thị Thu', 'BB', NULL, 'LĐ DH', NULL, NULL),
('101091', NULL, 'Bình', 'Dương Chiêu', 'KHO LẠNH', NULL, 'LĐ DH', NULL, NULL),
('101118', NULL, 'Hiếu', 'Trần Văn', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('101143', NULL, 'Tính', 'Võ Sỹ ', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101147', NULL, 'Tuyền', 'Trịnh Thị Cẩm ', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101151', NULL, 'Phúc', 'Huỳnh Văn ', 'P.V-3', NULL, 'LĐ DH', NULL, NULL),
('101153', NULL, 'Hùng', 'Lê Văn ', 'P.V-2', NULL, 'THỜI VỤ', NULL, NULL),
('101160', NULL, 'Minh', 'Nguyễn Văn', 'P.V-1', NULL, 'LĐ DH', NULL, NULL),
('101168', NULL, 'Yến', 'Luyện Thị ', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101179', NULL, 'Tâm', 'Phan Văn', 'P.V-1', NULL, 'THỜI VỤ', NULL, NULL),
('101183', NULL, 'Quang', 'Huỳnh Xuân', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101190', NULL, 'Phương', 'Lê Thị', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('101237', NULL, 'Quốc', 'Lê Thành', 'CĐ', NULL, 'LĐ DH', NULL, NULL),
('101238', NULL, 'Định', 'Phan Gia', 'CĐ', NULL, 'LĐ DH', NULL, NULL),
('101259', NULL, 'Liếu', 'Nguyễn Thị ', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101262', NULL, 'Hoa', 'Nguyễn Thị ', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101264', NULL, 'Non', 'Huỳnh Thanh', 'P.V-3', NULL, 'LĐ DH', NULL, NULL),
('101267', NULL, 'Lệ', 'Nguyễn Thị ', 'P.G', NULL, 'THỜI VỤ', NULL, NULL),
('101276', NULL, 'Mai', 'Nguyễn Thị Ngọc', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101320', NULL, 'Thanh', 'Phạm Ngọc', 'ĐT', NULL, 'LĐ DH', NULL, NULL),
('101326', NULL, 'Giang', 'Nguyễn Thị Cẩm ', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('101337', NULL, 'Chín', 'Nguyễn Thị', 'TV-X', NULL, 'LĐ DH', NULL, NULL),
('101354', NULL, 'Thanh', 'Nguyễn Thị ', 'TP', NULL, 'LĐ DH', NULL, NULL),
('101355', NULL, 'Thủy', 'Nguyễn Thị ', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101359', NULL, 'Hằng', 'Nguyễn Thị Thanh ', 'TT', NULL, 'LĐ DH', NULL, NULL),
('101369', NULL, 'Nguyền', 'Nguyễn Thị ', 'BB', NULL, 'LĐ DH', NULL, NULL),
('101379', NULL, 'Uyên', 'Trương Thị Xuân', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101405', NULL, 'Mum', 'Nguyễn Văn', 'CĐ', NULL, 'LĐ DH', NULL, NULL),
('101406', NULL, 'Diễm', 'Trịnh Kim ', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101411', NULL, 'Tới', 'Nguyễn Văn', 'ĐB', NULL, 'LĐ DH', NULL, NULL),
('101420', NULL, 'Lê', 'Nguyễn Thị ', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('101454', NULL, 'Phượng', 'Nguyễn Thị ', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101457', NULL, 'Thức', 'Võ Công', 'CĐ', NULL, 'LĐ DH', NULL, NULL),
('101458', NULL, 'Thư', 'Trần Nguyễn Anh', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101459', NULL, 'Nghĩa', 'Võ Huỳnh Nguyên', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101461', NULL, 'Sơn', 'Đặng Huỳnh Quốc Tây', 'CĐ', NULL, 'LĐ DH', NULL, NULL),
('101503', NULL, 'Tèo', 'Trần Văn', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('101504', NULL, 'Linh', 'Nguyễn Chúc ', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101521', NULL, 'Năm', 'Lê Văn ', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('101523', NULL, 'Vi', 'Nguyễn Vũ Thúy', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('101538', NULL, 'Thơ', 'Võ Ngọc Thi', 'BB', NULL, 'LĐ DH', NULL, NULL),
('101582', NULL, 'Điệp', 'Hồ Thị Hồng', 'LINE-2', NULL, 'LĐ DH', NULL, NULL),
('101585', NULL, 'Hồng', 'Nguyễn Thị Bé', 'LINE-2', NULL, 'LĐ DH', NULL, NULL),
('101589', NULL, 'Văn', 'Võ Phước', 'ĐT', NULL, 'LĐ DH', NULL, NULL),
('101596', NULL, 'Đào', 'Phan Thị Anh', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('101635', NULL, 'Ân', 'Lê Hoàng', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101636', NULL, 'Phúc', 'Nguyễn Thị Cẩm', 'TT', NULL, 'LĐ DH', NULL, NULL),
('101638', NULL, 'Phúc', 'Phạm Thanh', 'KHO LẠNH', NULL, 'LĐ DH', NULL, NULL),
('101643', NULL, 'Đen', 'Hồ Văn', 'CĐ', NULL, 'LĐ DH', NULL, NULL),
('101644', NULL, 'Nương', 'Ngô Thị Kim', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101646', NULL, 'Tánh', 'Phan Văn ', 'P.V-1', NULL, 'LĐ DH', NULL, NULL),
('101665', NULL, 'Vũ', 'Huỳnh Thái', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101669', NULL, 'Cường', 'Lê Văn', 'P.V-3', NULL, 'LĐ DH', NULL, NULL),
('101670', NULL, 'Vân', 'Sơn Thị', 'TV-B', NULL, 'LĐ DH', NULL, NULL),
('101689', NULL, 'Linh', 'Nguyễn Thị Cẩm', 'TP', NULL, 'LĐ DH', NULL, NULL),
('101701', NULL, 'Tiệc', 'Huỳnh Thị', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101704', NULL, 'Hiếu', 'Nguyễn Thị', 'TV-X', NULL, 'LĐ DH', NULL, NULL),
('101706', NULL, 'Thoa', 'Hồ Kim', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101722', NULL, 'Hồ', 'Nguyễn Văn', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101726', NULL, 'Hạnh', 'Phạm Thị Mỹ', 'ỐM-TS', NULL, 'LĐ DH', NULL, NULL),
('101746', NULL, 'Hằng', 'Nguyễn Thị', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('101748', NULL, 'Phú', 'Trương Thanh ', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('101752', NULL, 'Huy', 'Lê Quốc', 'ĐG', NULL, 'LĐ DH', NULL, NULL),
('101757', NULL, 'Loan', 'Võ Thị Hồng ', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101763', NULL, 'Nghĩa', 'Nguyễn Anh ', 'KHO LẠNH', NULL, 'LĐ DH', NULL, NULL),
('101765', NULL, 'Thoa', 'Huỳnh Thị Kim', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('101784', NULL, 'Bảo', 'Võ Văn Thiên', 'KHO LẠNH', NULL, 'LĐ DH', NULL, NULL),
('101792', NULL, 'Thủy', 'Phạm Thị', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('101795', NULL, 'Nỡ', 'Nguyễn Thị ', 'P.V-2', NULL, 'LĐ DH', NULL, NULL),
('101800', NULL, 'Yến', 'Đỗ Thị Bảo', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101832', NULL, 'Thọ', 'Nguyễn Văn ', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('101850', NULL, 'Tốt', 'Trương Thị Minh', 'ỐM-TS', NULL, 'LĐ DH', NULL, NULL),
('101878', NULL, 'Thắm', 'Ngô Thị Bích', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('101891', NULL, 'Hạnh', 'Phạm Thị Hồng ', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101914', NULL, 'Nghi', 'Trần Mẫn', 'LINE-2', NULL, 'THỜI VỤ', NULL, NULL),
('101921', NULL, 'Nhung', 'Võ Thị Hồng', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101943', NULL, 'Trung', 'Võ Toàn ', 'VP', NULL, 'LĐ DH', NULL, NULL),
('101944', NULL, 'Lan', 'Huỳnh Thị Mỹ', 'TP', NULL, 'LĐ DH', NULL, NULL),
('101945', NULL, 'Sen', 'Nguyễn Thị ', 'LINE-4', NULL, 'LĐ DH', NULL, NULL),
('101948', NULL, 'Em', 'Nguyễn Thị Nga', 'LINE-4', NULL, 'LĐ DH', NULL, NULL),
('101951', NULL, 'Ngân', 'Phạm', 'P.V-1', NULL, 'LĐ DH', NULL, NULL),
('101955', NULL, 'Hường', 'Nguyễn Thị Ngọc', 'ĐG', NULL, 'THỜI VỤ', NULL, NULL),
('101963', NULL, 'Hương', 'Huỳnh Thi Tuyết', 'LINE-4', NULL, 'LĐ DH', NULL, NULL),
('101966', NULL, 'Tư', 'Nguyễn Văn', 'NBV', NULL, 'LĐ DH', NULL, NULL),
('101972', NULL, 'Tuyền', 'Nguyễn Thị ', 'TP', NULL, 'LĐ DH', NULL, NULL),
('101973', NULL, 'Ty', 'Nguyễn Văn', 'NBV', NULL, 'LĐ DH', NULL, NULL),
('101974', NULL, 'Tốt', 'Nguyễn Văn', 'NBV', NULL, 'LĐ DH', NULL, NULL),
('101975', NULL, 'Mai', 'Trần Thanh', 'NBV', NULL, 'LĐ DH', NULL, NULL),
('101976', NULL, 'Hải', 'Nguyễn Nam', 'NBV', NULL, 'LĐ DH', NULL, NULL),
('101982', NULL, 'Thảo', 'Võ Thị Thu', 'LINE-4', NULL, 'LĐ DH', NULL, NULL),
('101999', NULL, 'Bằng', 'Nguyễn Thanh', 'VP', NULL, 'LĐ DH', NULL, NULL),
('102000', NULL, 'Hùng', 'Nguyễn Quốc', 'VP', NULL, 'LĐ DH', NULL, NULL),
('102008', NULL, 'Loan', 'Nguyễn Thị', 'LINE-1', NULL, 'LĐ DH', NULL, NULL),
('102039', NULL, 'Nhu', 'Trần Văn', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102040', NULL, 'Quốc', 'Huỳnh Hoàng Nam', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102041', NULL, 'Hậu', 'Trần Phúc', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102042', NULL, 'Tuyến', 'Huỳnh Nguyễn Thủy', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102043', NULL, 'Tiên', 'Trần Thị Thủy', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102044', NULL, 'Sang', 'Nguyễn Thị Hoàng', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102045', NULL, 'Nguyệt', 'Phạm Ánh', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102046', NULL, 'Ly', 'Võ Thị Thảo', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102048', NULL, 'Nguyện', 'Nguyễn Như', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102051', NULL, 'Thủy', 'Đoàn Thị ', 'ĐG', NULL, 'LĐ DH', NULL, NULL),
('102052', NULL, 'Em', 'Nguyễn Thị Út', 'ĐG', NULL, 'LĐ DH', NULL, NULL),
('102058', NULL, 'Thiện', 'Phạm Minh', 'KHO LẠNH', NULL, 'LĐ DH', NULL, NULL),
('102070', NULL, 'Đông', 'Nguyễn Văn ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102082', NULL, 'Vinh', 'Phan Phước', 'TP', NULL, 'LĐ DH', NULL, NULL),
('102083', NULL, 'Thơ', 'Phạm Thị Tiểu', 'TP', NULL, 'LĐ DH', NULL, NULL),
('102096', NULL, 'Chị', 'Lê Thị Điều', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('102100', NULL, 'Trường', 'Phạm Văn Đan', 'TP', NULL, 'THỜI VỤ', NULL, NULL),
('102101', NULL, 'Châu', 'Nguyễn Văn Minh', 'IQF', NULL, 'THỜI VỤ', NULL, NULL),
('102103', NULL, 'Châu', 'Võ Thị Mỹ', 'TP', NULL, 'THỜI VỤ', NULL, NULL),
('102105', NULL, 'Bảo', 'Lê Quốc', 'IQF', NULL, 'THỜI VỤ', NULL, NULL),
('102108', NULL, 'Bình', 'Huỳnh Thanh', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102197', NULL, 'Để', 'Nguyễn Tấn', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('102199', NULL, 'Ánh', 'Nguyễn Thị', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('102208', NULL, 'Linh', 'Lê Thị Mỹ', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('102210', NULL, 'Huy', 'Nguyễn Hoàng', 'VP', NULL, 'LĐ DH', NULL, NULL),
('102214', NULL, 'Tiến', 'Nguyễn Ngọc', 'ĐG', NULL, 'LĐ DH', NULL, NULL),
('102217', NULL, 'Oanh', 'Trần Kiều', 'TP', NULL, 'THỜI VỤ', NULL, NULL),
('102220', NULL, 'Phên', 'Nguyễn Văn ', 'NBV', NULL, 'LĐ DH', NULL, NULL),
('102222', NULL, 'Hiền', 'Phan Thị Diệu ', 'VP', NULL, 'LĐ DH', NULL, NULL),
('102227', NULL, 'Út', 'Lý Văn ', 'ĐB', NULL, 'LĐ DH', NULL, NULL),
('102230', NULL, 'Hiếu', 'Nguyễn Trung', 'CĐ', NULL, 'LĐ DH', NULL, NULL),
('102236', NULL, 'Lành', 'Phùng Thị ', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('102241', NULL, 'Hậu', 'Hứa Minh ', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102245', NULL, 'Trúc', 'Nguyễn Thị Thanh ', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102247', NULL, 'Long', 'Nguyễn Thành ', 'P.V-1', NULL, 'LĐ DH', NULL, NULL),
('102248', NULL, 'Đông', 'Nguyễn Công ', 'P.V-1', NULL, 'THỜI VỤ', NULL, NULL),
('102253', NULL, 'Cương', 'Trần Biên', 'IQF', NULL, 'LĐ DH', NULL, NULL),
('102256', NULL, 'Tiên', 'Nguyễn Thị Thủy', 'LINE-3', NULL, 'LĐ DH', NULL, NULL),
('102257', NULL, 'Huy', 'Nguyễn Võ Tuấn ', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102258', NULL, 'Diễm', 'Phạm Ngọc ', 'VP SG', NULL, 'LĐ DH', NULL, NULL),
('102262', NULL, 'Sương', 'Nguyễn Thị Thu ', 'VP', NULL, 'LĐ DH', NULL, NULL),
('102263', NULL, 'Linh', 'Huỳnh Tuấn', 'P.V-1', NULL, 'THỜI VỤ', NULL, NULL),
('102266', NULL, 'Phú', 'Nguyễn Thanh ', 'LINE-4', NULL, 'THỜI VỤ', NULL, NULL),
('102268', NULL, 'Ngọc', 'Huỳnh Thị Kim ', 'TP', NULL, 'THỜI VỤ', NULL, NULL),
('102270', NULL, 'Sang', 'Nguyễn Minh ', 'P.V-1', NULL, 'THỜI VỤ', NULL, NULL),
('102277', NULL, 'Phúc', 'Phan Văn ', 'ĐG', NULL, 'THỜI VỤ', NULL, NULL),
('102279', NULL, 'Hưởng', 'Nguyễn Tấn', 'P.V-1', NULL, 'THỜI VỤ', NULL, NULL),
('102281', NULL, 'Nhựt', 'Bùi Minh', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102282', NULL, 'Quyên', 'Trần Thị Hoàng ', 'VP', NULL, 'LĐ DH', NULL, NULL),
('102284', NULL, 'Hùng', 'Nguyễn Phi', 'IQF', NULL, 'THỜI VỤ', NULL, NULL),
('102285', NULL, 'Quí', 'Nguyễn Văn ', 'IQF', NULL, 'THỜI VỤ', NULL, NULL),
('102288', NULL, 'Hoàng', 'Đặng Minh', 'VP', NULL, 'LĐ DH', NULL, NULL),
('102289', NULL, 'Sanh', 'Châu Văn', 'NBV', NULL, 'LĐ DH', NULL, NULL),
('102292', NULL, 'Luân', 'Võ Thành', 'TP', NULL, 'THỜI VỤ', NULL, NULL),
('102293', NULL, 'Ngọc', 'Huỳnh Kim', 'IQF', NULL, 'THỜI VỤ', NULL, NULL),
('102294', NULL, 'Ly', 'Phùng Thị Cẩm ', 'TP', NULL, 'THỜI VỤ', NULL, NULL),
('102295', NULL, 'An', 'Nguyễn Thế', 'TP', NULL, 'THỜI VỤ', NULL, NULL),
('102296', NULL, 'Đẹp', 'Đinh Thị', 'TP', NULL, 'THỜI VỤ', NULL, NULL),
('102298', NULL, 'Thanh', 'Phùng Chí ', 'IQF', NULL, 'THỜI VỤ', NULL, NULL),
('102299', NULL, 'Ngọc', 'Nguyễn Thị Hồng', 'IQF', NULL, 'THỜI VỤ', NULL, NULL),
('102302', NULL, 'Như', 'Võ Thị Quỳnh ', 'TP', NULL, 'THỜI VỤ', NULL, NULL),
('102303', NULL, 'Quyền', 'Dương Thị Mỹ ', 'IQF', NULL, 'THỜI VỤ', NULL, NULL),
('102304', NULL, 'Phượng', 'Lê Thị Bích ', 'IQF', NULL, 'THỜI VỤ', NULL, NULL),
('102306', NULL, 'Ngân', 'Trương Thị Ngọc ', 'IQF', NULL, 'THỜI VỤ', NULL, NULL),
('102307', NULL, 'Vy', 'Võ Ngọc Lam', 'IQF', NULL, 'THỜI VỤ', NULL, NULL),
('102308', NULL, 'Ngân', 'Nguyễn Thị Kim', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102310', NULL, 'Quyên', 'Lê Thị Kim ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102311', NULL, 'Trường', 'Đoàn Nhựt', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102312', NULL, 'Sương', 'Nguyễn Thị Thu ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102313', NULL, 'Uyên', 'Nguyễn Thị Thu ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102314', NULL, 'Huy', 'Trương Đang', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102317', NULL, 'Tý', 'Nguyễn Minh', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102319', NULL, 'Phụng', 'Ngô Huỳnh Kim ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102320', NULL, 'Loan', 'Ngô Huỳnh Kim ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102321', NULL, 'Tâm', 'Nguyễn Chí', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102322', NULL, 'Hạnh', 'Dương Thị ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102325', NULL, 'Ly', 'Nguyễn Thị Cẩm ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102326', NULL, 'Phượng', 'Ngô Thị Mỹ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102327', NULL, 'Bình', 'Ngô Công ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102328', NULL, 'Nhân', 'Lê Hoài', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102329', NULL, 'Loan', 'Huỳnh Thị Kim ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102330', NULL, 'Thi', 'Trương Thị Kim ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102331', NULL, 'Hương', 'Lê Thị Kim', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102332', NULL, 'Chung', 'Võ Thị Kim ', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL),
('102333', NULL, 'Byă', 'H\' Hút', 'LINE-7', NULL, 'THỜI VỤ', NULL, NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `migrations`
--

CREATE TABLE `migrations` (
  `id` int(10) UNSIGNED NOT NULL,
  `migration` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `batch` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Đang đổ dữ liệu cho bảng `migrations`
--

INSERT INTO `migrations` (`id`, `migration`, `batch`) VALUES
(1, '2014_10_12_000000_create_users_table', 1),
(2, '2014_10_12_100000_create_password_resets_table', 1),
(3, '2019_06_22_084508_create_password_securities_table', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nhom`
--

CREATE TABLE `nhom` (
  `id` int(10) UNSIGNED NOT NULL,
  `name` varchar(255) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Đang đổ dữ liệu cho bảng `nhom`
--

INSERT INTO `nhom` (`id`, `name`, `created_at`, `updated_at`, `deleted_at`) VALUES
(1, 'Nhóm 1', NULL, NULL, NULL),
(2, 'Nhóm 2', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `password_resets`
--

CREATE TABLE `password_resets` (
  `email` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `token` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `password_securities`
--

CREATE TABLE `password_securities` (
  `id` int(10) UNSIGNED NOT NULL,
  `user_id` int(11) NOT NULL,
  `google2fa_enable` tinyint(1) NOT NULL DEFAULT '0',
  `google2fa_secret` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Đang đổ dữ liệu cho bảng `password_securities`
--

INSERT INTO `password_securities` (`id`, `user_id`, `google2fa_enable`, `google2fa_secret`, `created_at`, `updated_at`) VALUES
(1, 1, 0, 'IZ6D5I3MA4QWMA3J', '2019-06-30 20:15:21', '2019-06-30 20:22:00');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `settings`
--

CREATE TABLE `settings` (
  `id` int(10) UNSIGNED NOT NULL,
  `date` date NOT NULL,
  `ca_id` int(10) UNSIGNED NOT NULL,
  `bophan_id` int(10) UNSIGNED NOT NULL,
  `ngay_rot_ca` datetime DEFAULT NULL,
  `checkin` int(11) NOT NULL COMMENT '10, 15, 20 phút tùy bộ phận',
  `checkout` int(11) NOT NULL COMMENT '10, 15, 20 phút tùy bộ phận',
  `work_in` varchar(5) NOT NULL,
  `work_out` varchar(5) CHARACTER SET utf8 COLLATE utf8_estonian_ci NOT NULL,
  `overtime_in` varchar(5) NOT NULL,
  `overtime_out` varchar(5) NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `settings_nhom`
--

CREATE TABLE `settings_nhom` (
  `setting_id` int(10) UNSIGNED NOT NULL,
  `nhom_id` int(10) UNSIGNED NOT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL,
  `deleted_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `users`
--

CREATE TABLE `users` (
  `id` int(10) UNSIGNED NOT NULL,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `username` varchar(255) NOT NULL,
  `email` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `role` tinyint(4) NOT NULL DEFAULT '0' COMMENT '0: User Normal; 1: Admin; 2: User Data; 3: User Settings',
  `email_verified_at` timestamp NULL DEFAULT NULL,
  `api_token` varchar(60) NOT NULL,
  `password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `remember_token` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT NULL,
  `updated_at` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Đang đổ dữ liệu cho bảng `users`
--

INSERT INTO `users` (`id`, `name`, `username`, `email`, `role`, `email_verified_at`, `api_token`, `password`, `remember_token`, `created_at`, `updated_at`) VALUES
(1, 'admin', 'admin', 'lua19860223@gmail.com', 1, NULL, 'q43tZq9k0MvjPEvRa5eqCd2uWyB1g0Y8Kzr4tZ4mEmDcRU1hYpQAjEQUyka9', '$2y$10$ZGr4sgrLAJKtDF0WnBEuguN4TCHr64HDWirQdrNxMI7e6./eFN4ba', '4qUPPHWdya1OcuMHOMa8jG71JQio9YRMpQR88zJFNOH5gtnNUOjk5ZXVh17E', '2019-06-23 00:23:05', '2019-06-23 00:23:05'),
(3, 'user1', 'user1', 'user1@louyco.com', 2, NULL, '67fWtfQnw0fSoe17BxFgQXfLBJ2avqUdQFWPqp4PZXxQs9zFKUwo8YYaeIsu', '$2y$10$Sorp2iHX2.Y/TfD9mz9hyOXL3vMRCbByjl6xxgA.fmBz.R2YTkcE6', NULL, '2019-07-02 08:38:08', '2019-07-02 08:38:08'),
(4, 'user2', 'user2', 'user2@louyco.com', 3, NULL, 'uEhwMaDGISinRZhrGjqI0pIcoeToMZDz340bWD99NHTftfX2vAqzEdrKvOty', '$2y$10$e7xwB4Fg9twbLwozbyoWH.HAQVillXaJuhbDXc0wirIeCEjzZltHS', NULL, '2019-07-02 08:38:33', '2019-07-02 08:38:33');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `bophan`
--
ALTER TABLE `bophan`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `ca`
--
ALTER TABLE `ca`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `checkin`
--
ALTER TABLE `checkin`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `company`
--
ALTER TABLE `company`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`emp_no`),
  ADD KEY `bophan_id` (`bophan_id`);

--
-- Chỉ mục cho bảng `migrations`
--
ALTER TABLE `migrations`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `nhom`
--
ALTER TABLE `nhom`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `password_resets`
--
ALTER TABLE `password_resets`
  ADD KEY `password_resets_email_index` (`email`);

--
-- Chỉ mục cho bảng `password_securities`
--
ALTER TABLE `password_securities`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `settings`
--
ALTER TABLE `settings`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `settings_nhom`
--
ALTER TABLE `settings_nhom`
  ADD PRIMARY KEY (`setting_id`,`nhom_id`);

--
-- Chỉ mục cho bảng `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `users_email_unique` (`email`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `bophan`
--
ALTER TABLE `bophan`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT cho bảng `ca`
--
ALTER TABLE `ca`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `checkin`
--
ALTER TABLE `checkin`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `company`
--
ALTER TABLE `company`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT cho bảng `migrations`
--
ALTER TABLE `migrations`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `nhom`
--
ALTER TABLE `nhom`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT cho bảng `password_securities`
--
ALTER TABLE `password_securities`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT cho bảng `settings`
--
ALTER TABLE `settings`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `users`
--
ALTER TABLE `users`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `employees`
--
ALTER TABLE `employees`
  ADD CONSTRAINT `employees_ibfk_1` FOREIGN KEY (`bophan_id`) REFERENCES `bophan` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
