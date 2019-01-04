-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Hoszt: 127.0.0.1
-- Létrehozás ideje: 2018. Dec 17. 15:51
-- Szerver verzió: 5.6.17
-- PHP verzió: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Adatbázis: `cs_harcosok`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `harcosok`
--

CREATE TABLE IF NOT EXISTS `harcosok` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nev` varchar(80) NOT NULL,
  `letrehozas` date NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nev` (`nev`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- A tábla adatainak kiíratása `harcosok`
--

INSERT INTO `harcosok` (`id`, `nev`, `letrehozas`) VALUES
(1, 'Son Goku', '2018-12-14'),
(2, 'Vegeta', '2018-12-27'),
(3, 'Piccolo', '2018-12-18');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kepessegek`
--

CREATE TABLE IF NOT EXISTS `kepessegek` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nev` varchar(200) NOT NULL,
  `leiras` varchar(1000) NOT NULL,
  `harcos_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nev` (`nev`),
  KEY `harcos_id` (`harcos_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- A tábla adatainak kiíratása `kepessegek`
--

INSERT INTO `kepessegek` (`id`, `nev`, `leiras`, `harcos_id`) VALUES
(1, 'Kamehameha', 'Sugarnyalab, forro, pusztito', 1),
(2, 'Kaioken', 'Eronoveles sokszorosara, kartetel onmagaban', 1),
(3, 'Genki Dama', 'Energiabomba kornyezo elolenyek erejebol, idoigenyes', 1),
(4, 'Azonnali atvitel', 'Teleportalas az ido tort resze alatt, tudnia kell hova megy', 1),
(5, 'Fuzio', 'Hasonloan eros harcossal valo egyesules, egy megerosebb harcost alkotva', 1),
(7, 'Fuzio2', 'Hasonloan eros harcossal valo egyesules, egy megerosebb harcost alkotva', 2),
(8, 'Vegso Villanas', 'Duhosebb sugarnyalab, tovabb toltheto', 2),
(9, 'Nameki gyogyero', 'Vajdnem azonnali regeneraciós kepessegek', 3),
(10, 'Kulonleges sugaragyu', 'Koncentralt energianyalab, vajdnem mindent atjukaszt, idoigenyes', 3),
(11, 'Nyulekony vegtagok', 'Hosszabb az elerese par meterrel, mint az atlag humanoide', 3);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `kepessegek`
--
ALTER TABLE `kepessegek`
  ADD CONSTRAINT `kepessegek_ibfk_1` FOREIGN KEY (`harcos_id`) REFERENCES `harcosok` (`id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
