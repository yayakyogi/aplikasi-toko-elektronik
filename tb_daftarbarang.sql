-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Jun 2020 pada 08.31
-- Versi server: 10.4.11-MariaDB
-- Versi PHP: 7.2.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `toko_elektronik`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_daftarbarang`
--

CREATE TABLE `tb_daftarbarang` (
  `id` varchar(100) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `jenis` varchar(100) NOT NULL,
  `tipe` varchar(100) NOT NULL,
  `harga` varchar(20) NOT NULL,
  `stock` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_daftarbarang`
--

INSERT INTO `tb_daftarbarang` (`id`, `nama`, `jenis`, `tipe`, `harga`, `stock`) VALUES
('kk1', 'Sharp', 'Kulkas', '1 Pintu', '1000000', '1'),
('kk2', 'Sharp A', 'Kulkas', '2 Pintu', '1500000', '1'),
('lcd1', 'Samsung Aquos2', 'Televisi', 'LCD', '2000000', '1'),
('led1', 'Samsung Aquos', 'Televisi', 'LED', '5000000', '2'),
('nw1', 'Sony Duo', 'Radio', 'Non Wireless', '700000', '2'),
('tb1', 'Sony', 'Televisi', 'Tabung', '500000', '2');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_daftarbarang`
--
ALTER TABLE `tb_daftarbarang`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
