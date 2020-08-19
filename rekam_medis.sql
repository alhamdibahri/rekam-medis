-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 08 Des 2018 pada 21.34
-- Versi Server: 5.6.24
-- PHP Version: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `rekam_medis`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `dokter`
--

CREATE TABLE IF NOT EXISTS `dokter` (
  `kodeDokter` varchar(8) NOT NULL,
  `namaDokter` varchar(50) NOT NULL,
  `spesialis` varchar(50) NOT NULL,
  `jk` varchar(10) NOT NULL,
  `alamat` text NOT NULL,
  `no_hp` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `dokter`
--

INSERT INTO `dokter` (`kodeDokter`, `namaDokter`, `spesialis`, `jk`, `alamat`, `no_hp`) VALUES
('DTR-001', 'Drg. Bambang Mulyono', 'Gigi', 'Laki-Laki', 'Jl. Brikjen Katamso Gg. Markisa', '082301261900'),
('DTR-002', 'Dr. Ilham Nasution', 'Jantung', 'Laki-Laki', 'Jl. Gaperta', '0852111225'),
('DTR-003', 'Dr. Joko Sulistiono', 'Otak', 'Laki-Laki', 'Medan', '0852332121'),
('DTR-004', 'Dr. Ningsih Hasibuan', 'Kandungan', 'Perempuan', 'Jl. Bromo Ujung No. 255', '085112212121'),
('DTR-005', 'Dr. Jaka Siregar', 'Hati', 'Laki-Laki', 'Jl. Sisingamangaraja No. 432', '083158585411'),
('DTR-006', 'Dr. Zulkifli Nizar', 'Bedah', 'Laki-Laki', 'Jl. Seksama Patean', '0823121312');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jadwal_dokter`
--

CREATE TABLE IF NOT EXISTS `jadwal_dokter` (
  `kodeJadwal` varchar(8) NOT NULL,
  `kodeDokter` varchar(8) NOT NULL,
  `waktu` varchar(225) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jadwal_dokter`
--

INSERT INTO `jadwal_dokter` (`kodeJadwal`, `kodeDokter`, `waktu`) VALUES
('JWD-001', 'DTR-001', 'Senin (10.00-12.00) WIB\r\nRabu (13.00-15.00) WIB\r\n\nSabtu  (15.00-19.00) WIB '),
('JWD-002', 'DTR-003', 'Kamis (10.00-12.00) WIB\r\nJumat (13.00-15.00) WIB\r\nSabtu  (15.00-19.00) WIB  ');

-- --------------------------------------------------------

--
-- Struktur dari tabel `kamar`
--

CREATE TABLE IF NOT EXISTS `kamar` (
  `kodeKamar` varchar(8) NOT NULL,
  `namaKamar` varchar(50) NOT NULL,
  `lantai_kamar` int(11) NOT NULL,
  `status` varchar(15) NOT NULL,
  `ket` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `kamar`
--

INSERT INTO `kamar` (`kodeKamar`, `namaKamar`, `lantai_kamar`, `status`, `ket`) VALUES
('KMR-001', 'Melati', 1, '-', '-'),
('KMR-002', 'Nangka', 2, 'Full', '-');

-- --------------------------------------------------------

--
-- Struktur dari tabel `konsul_spesial`
--

CREATE TABLE IF NOT EXISTS `konsul_spesial` (
  `kodespealis` varchar(8) NOT NULL,
  `nama_spesialis` varchar(150) NOT NULL,
  `harga_spesialis` bigint(20) NOT NULL,
  `kodeTindakan` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `konsul_spesial`
--

INSERT INTO `konsul_spesial` (`kodespealis`, `nama_spesialis`, `harga_spesialis`, `kodeTindakan`) VALUES
('SPS-001', 'Kardiolog', 300000, 'TDK-001'),
('SPS-002', 'Audiolog', 250000, 'TDK-001'),
('SPS-003', 'Dokter gigi', 200000, 'TDK-001'),
('SPS-004', 'Dokter THT', 150000, 'TDK-001'),
('SPS-005', 'Ginekolog', 200000, 'TDK-001'),
('SPS-006', 'Dokter ortopedi', 130000, 'TDK-001'),
('SPS-007', 'Anak', 50000, 'TDK-001'),
('SPS-008', 'Radiolog', 120000, 'TDK-001'),
('SPS-009', 'Internis', 100000, 'TDK-001'),
('SPS-010', 'Ahli saraf', 110000, 'TDK-001'),
('SPS-011', 'Obsgin', 115000, 'TDK-001'),
('SPS-012', 'Kulit', 200000, 'TDK-001'),
('SPS-013', 'Bedah', 300000, 'TDK-001'),
('SPS-014', 'Orthopedi', 220000, 'TDK-001'),
('SPS-015', 'Onkologi', 140000, 'TDK-001');

-- --------------------------------------------------------

--
-- Struktur dari tabel `obat`
--

CREATE TABLE IF NOT EXISTS `obat` (
  `id_obat` varchar(8) NOT NULL,
  `nama_obat` varchar(150) NOT NULL,
  `jmlh_obat` int(12) NOT NULL,
  `satuan` varchar(150) NOT NULL,
  `detail` varchar(150) NOT NULL,
  `harga` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `obat`
--

INSERT INTO `obat` (`id_obat`, `nama_obat`, `jmlh_obat`, `satuan`, `detail`, `harga`) VALUES
('OBT-001', 'Amoxsan 250 mg', 8, '-', '-', 20000),
('OBT-002', 'Celestamine', 10, '-', '-', 30000),
('OBT-003', 'Triaminic batuk pilek syrup', 10, '-', '-', 10000),
('OBT-004', 'Toplexil syrup 120 ml', 10, '-', '-', 12000),
('OBT-005', 'Vocefa forte 250 mg DS', 9, '-', '-', 13500),
('OBT-006', 'Ventolin exp syrup', 9, '-', '-', 11000),
('OBT-007', 'Bioplacenton gel', 10, '-', '-', 12500),
('OBT-008', 'Burnazin Zalf', 10, '-', '-', 130000),
('OBT-009', 'Bethadine zalf 10 gr', 10, '-', '-', 40000),
('OBT-010', 'Benoson cr', 10, '-', '-', 50000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `pasien`
--

CREATE TABLE IF NOT EXISTS `pasien` (
  `kodepasien` varchar(8) NOT NULL,
  `namapasien` varchar(50) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `jk` varchar(10) NOT NULL,
  `alamat` text NOT NULL,
  `umur` int(11) NOT NULL,
  `tgl_daftar` date NOT NULL,
  `jam_daftar` varchar(10) NOT NULL,
  `teleponpasien` varchar(15) NOT NULL,
  `status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pasien`
--

INSERT INTO `pasien` (`kodepasien`, `namapasien`, `tgl_lahir`, `jk`, `alamat`, `umur`, `tgl_daftar`, `jam_daftar`, `teleponpasien`, `status`) VALUES
('PSN-001', 'Alhamdi Ferdiawan Bahri', '2000-11-23', 'Laki-Laki', 'Jalan Pahlawan IV/02 Pamolokan Sumenep', 18, '2018-11-22', '08:41', '082301261900', 'Rawat Inap'),
('PSN-002', 'Dita Maharani Dewi', '1994-02-09', 'Perempuan', 'Surabaya', 24, '2018-12-07', '08:41', '0823019810810', '-'),
('PSN-003', 'Farel Putra hidayat', '2000-10-10', 'Laki-Laki', ',j', 18, '2018-11-22', '05:05', '089070970970', '-'),
('PSN-004', 'Wajdi Majdi', '2000-06-06', 'Laki-Laki', 'kolor', 18, '2018-11-22', '01:17', '088230161917', '-');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penyakit`
--

CREATE TABLE IF NOT EXISTS `penyakit` (
  `id_penyakit` varchar(10) NOT NULL,
  `nama_penyakit` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `penyakit`
--

INSERT INTO `penyakit` (`id_penyakit`, `nama_penyakit`) VALUES
('PNY-001', 'Apendiksitis'),
('PNY-002', 'Ginekologi'),
('PNY-003', 'Hati lainnya'),
('PNY-004', 'Hemia'),
('PNY-005', 'Hemoroid'),
('PNY-006', 'Hiperlipidemia'),
('PNY-007', 'Hipertensi'),
('PNY-008', 'ISPA'),
('PNY-009', 'Jantung'),
('PNY-010', 'Karsinoma'),
('PNY-011', 'Kecelakaan'),
('PNY-012', 'Asma'),
('PNY-013', 'Kehamilan Norma'),
('PNY-014', 'Kontrasepsi'),
('PNY-015', 'Kulit'),
('PNY-016', 'Migren & Sindro'),
('PNY-017', 'Neurologi'),
('PNY-018', 'Osteoarteritis'),
('PNY-019', 'Psikosis'),
('PNY-020', 'Sinusitis'),
('PNY-021', 'Sist Kemih Lain'),
('PNY-022', 'Sist muskuloske'),
('PNY-023', 'Anemia'),
('PNY-024', 'Telinga'),
('PNY-025', 'Thyroid'),
('PNY-026', 'Tuberculosis'),
('PNY-027', 'Hiperpuricemia'),
('PNY-028', 'Tumor'),
('PNY-029', 'Paru'),
('PNY-030', 'Imsomnia'),
('PNY-031', 'Demam'),
('PNY-032', 'Hipotensi'),
('PNY-033', 'Diare'),
('PNY-034', 'Diabetes Melitu'),
('PNY-035', 'Diare & Gastroe'),
('PNY-036', 'Gangguan Ginjal'),
('PNY-037', 'Gangguan Mata'),
('PNY-038', 'Gasteritis & Du'),
('PNY-039', 'Gigi & Mulut'),
('PNY-040', 'Sakit Gigi'),
('PNY-041', 'Demam Berdarah Dengue'),
('PNY-042', 'sakit kelamin');

-- --------------------------------------------------------

--
-- Struktur dari tabel `rawat_inap`
--

CREATE TABLE IF NOT EXISTS `rawat_inap` (
  `id` int(11) NOT NULL,
  `nomorRm` varchar(10) NOT NULL,
  `dokter` varchar(10) NOT NULL,
  `diagnosa` varchar(255) NOT NULL,
  `tgl_berobat` date NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `rawat_inap`
--

INSERT INTO `rawat_inap` (`id`, `nomorRm`, `dokter`, `diagnosa`, `tgl_berobat`) VALUES
(4, 'RMK-001', 'DTR-002', 'sffs', '2018-12-07');

--
-- Trigger `rawat_inap`
--
DELIMITER $$
CREATE TRIGGER `kurangitotal` AFTER DELETE ON `rawat_inap`
 FOR EACH ROW BEGIN
UPDATE rekammedik SET totharga=totharga-350000 WHERE nomorRm=old.nomorRm;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `tambahtotal` AFTER INSERT ON `rawat_inap`
 FOR EACH ROW BEGIN
UPDATE rekammedik SET totharga=totharga+350000 WHERE nomorRm=NEW.nomorRm;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `rekammedik`
--

CREATE TABLE IF NOT EXISTS `rekammedik` (
  `nomorRm` varchar(8) NOT NULL,
  `kodepasien` varchar(8) NOT NULL,
  `kodeDokter` varchar(8) NOT NULL,
  `keluhan` varchar(50) NOT NULL,
  `diagnosa` varchar(50) NOT NULL,
  `tindakan` varchar(8) NOT NULL,
  `namatindakan` varchar(50) NOT NULL,
  `kodeKamar` varchar(8) NOT NULL,
  `spesialis` varchar(8) NOT NULL,
  `id_penyakit` varchar(10) NOT NULL,
  `jam` varchar(10) NOT NULL,
  `tanggal` date NOT NULL,
  `totharga` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `rekammedik`
--

INSERT INTO `rekammedik` (`nomorRm`, `kodepasien`, `kodeDokter`, `keluhan`, `diagnosa`, `tindakan`, `namatindakan`, `kodeKamar`, `spesialis`, `id_penyakit`, `jam`, `tanggal`, `totharga`) VALUES
('RMK-001', 'PSN-001', 'DTR-001', 'demam', 'terkena DBD', 'TDK-005', 'Rawat Inap', 'KMR-002', '', 'PNY-041', '09:17', '2018-12-06', 700000),
('RMK-002', 'PSN-001', 'DTR-003', 'jhgjh', 'klj', 'TDK-006', 'Haemodialisa', '', '', 'PNY-027', '10:52', '2018-12-06', 200000),
('RMK-003', 'PSN-003', 'DTR-002', 'pusing', 'kekurangan cairan', 'TDK-006', 'Haemodialisa', '', '', 'PNY-027', '05:08', '2018-12-08', 200000),
('RMK-004', 'PSN-004', 'DTR-003', 'demam', 'Terkena Demam Berdarah', 'TDK-005', 'Rawat Inap', 'KMR-001', '', 'PNY-041', '01:20', '2018-12-09', 350000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tindakan`
--

CREATE TABLE IF NOT EXISTS `tindakan` (
  `kodeTindakan` varchar(8) NOT NULL,
  `namaTindakan` varchar(50) NOT NULL,
  `harga_tindakan` bigint(20) NOT NULL,
  `ket` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tindakan`
--

INSERT INTO `tindakan` (`kodeTindakan`, `namaTindakan`, `harga_tindakan`, `ket`) VALUES
('TDK-001', 'Konsultasi Dokter Spesialis', 0, '-'),
('TDK-002', 'Pemeriksaan Laboratorium', 300000, '-'),
('TDK-003', 'Pemeriksaan Radiologi', 250000, '-'),
('TDK-004', 'Fisioterapi', 270000, '-'),
('TDK-005', 'Rawat Inap', 350000, '-'),
('TDK-006', 'Haemodialisa', 200000, '-');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tmp_obat`
--

CREATE TABLE IF NOT EXISTS `tmp_obat` (
  `id_temp` int(11) NOT NULL,
  `nomorRm` varchar(8) NOT NULL,
  `id_obat` varchar(8) NOT NULL,
  `ambil` int(11) NOT NULL,
  `jam_ambil` varchar(10) NOT NULL,
  `tgl_ambil` date NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tmp_obat`
--

INSERT INTO `tmp_obat` (`id_temp`, `nomorRm`, `id_obat`, `ambil`, `jam_ambil`, `tgl_ambil`) VALUES
(2, 'RMK-001', 'OBT-001', 1, '09:24', '2018-12-06'),
(5, 'RMK-002', 'OBT-006', 1, '12:13', '2018-12-06'),
(8, 'RMK-003', 'OBT-001', 1, '05:08', '2018-12-08'),
(9, 'RMK-004', 'OBT-005', 1, '01:23', '2018-12-09');

--
-- Trigger `tmp_obat`
--
DELIMITER $$
CREATE TRIGGER `kurangi_stok` AFTER INSERT ON `tmp_obat`
 FOR EACH ROW BEGIN
UPDATE obat SET jmlh_obat=jmlh_obat-NEW.ambil WHERE id_obat=new.id_obat;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `update_stok` AFTER DELETE ON `tmp_obat`
 FOR EACH ROW BEGIN
UPDATE obat SET jmlh_obat=jmlh_obat+old.ambil WHERE id_obat=old.id_obat;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `user_man`
--

CREATE TABLE IF NOT EXISTS `user_man` (
  `kodeuser` varchar(8) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `jk` varchar(12) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(32) NOT NULL,
  `level` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `user_man`
--

INSERT INTO `user_man` (`kodeuser`, `nama`, `jk`, `username`, `password`, `level`) VALUES
('USR-001', 'Alhamdi Ferdiawan Bahri', 'Laki-Laki', 'admin', '21232F297A57A5A743894A0E4A801FC3', 'Admin'),
('USR-002', 'Ronaldo Wati', 'Perempuan', 'wati', '4616A5AB5A173017263BD059E17F8391', 'Admin'),
('USR-003', 'Farel Putra Hidayat', 'Laki-Laki', 'farel', '5579A2166B5FC9C4185975045FC2FC35', 'Petugas'),
('USR-004', 'M Ainur Romadhani', 'Laki-Laki', 'dhani', 'DA92F7066E5B27648D685CD6CF84F4BB', 'Petugas'),
('USR-006', 'Illyana Qurani Bahri', 'Perempuan', 'illyn', '8EFE223A32BDE5A47DB23D07AAC81561', 'Petugas'),
('USR-007', 'M Saiful Bahri', 'Laki-Laki', 'bahri', '846C25EAD0E84F2D7CCF10922F682278', 'Petugas'),
('USR-008', 'Adinda Pratiwi', 'Perempuan', 'tiwi', '8751139513877752980FB2996012AF64', 'Petugas');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `dokter`
--
ALTER TABLE `dokter`
  ADD PRIMARY KEY (`kodeDokter`);

--
-- Indexes for table `jadwal_dokter`
--
ALTER TABLE `jadwal_dokter`
  ADD PRIMARY KEY (`kodeJadwal`);

--
-- Indexes for table `kamar`
--
ALTER TABLE `kamar`
  ADD PRIMARY KEY (`kodeKamar`);

--
-- Indexes for table `konsul_spesial`
--
ALTER TABLE `konsul_spesial`
  ADD PRIMARY KEY (`kodespealis`);

--
-- Indexes for table `obat`
--
ALTER TABLE `obat`
  ADD PRIMARY KEY (`id_obat`);

--
-- Indexes for table `pasien`
--
ALTER TABLE `pasien`
  ADD PRIMARY KEY (`kodepasien`);

--
-- Indexes for table `penyakit`
--
ALTER TABLE `penyakit`
  ADD PRIMARY KEY (`id_penyakit`);

--
-- Indexes for table `rawat_inap`
--
ALTER TABLE `rawat_inap`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `rekammedik`
--
ALTER TABLE `rekammedik`
  ADD PRIMARY KEY (`nomorRm`);

--
-- Indexes for table `tindakan`
--
ALTER TABLE `tindakan`
  ADD PRIMARY KEY (`kodeTindakan`);

--
-- Indexes for table `tmp_obat`
--
ALTER TABLE `tmp_obat`
  ADD PRIMARY KEY (`id_temp`);

--
-- Indexes for table `user_man`
--
ALTER TABLE `user_man`
  ADD PRIMARY KEY (`kodeuser`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `rawat_inap`
--
ALTER TABLE `rawat_inap`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tmp_obat`
--
ALTER TABLE `tmp_obat`
  MODIFY `id_temp` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
