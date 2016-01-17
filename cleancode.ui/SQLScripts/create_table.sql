-- drop tables
DROP TABLE IF EXISTS Country;
DROP TABLE IF EXISTS ContinentTable;
DROP TABLE IF EXISTS City;
DROP TABLE IF EXISTS CountryLanguage;
DROP TABLE IF EXISTS TrueFalseTable;

-- create tables
CREATE TABLE 'ContinentTable' (
  'Continent' char(13) NOT NULL DEFAULT 'Asia',
  'ContinentId' int(11)
);

CREATE TABLE TrueFalseTable (
  'Value' char(1) NOT NULL DEFAULT 'F'
);

INSERT INTO ContinentTable VALUES ('Asia',1);
INSERT INTO ContinentTable VALUES ('Europe',2);
INSERT INTO ContinentTable VALUES ('North America',3);
INSERT INTO ContinentTable VALUES ('Africa',4);
INSERT INTO ContinentTable VALUES ('Oceania',5);
INSERT INTO ContinentTable VALUES ('Antarctica',6);
INSERT INTO ContinentTable VALUES ('South America',7);

INSERT INTO TrueFalseTable VALUES ('T');
INSERT INTO TrueFalseTable VALUES ('F');


CREATE TABLE `Country` (
  `Code` char(3) NOT NULL PRIMARY KEY,
  `Name` char(52) NOT NULL DEFAULT '',
  `Continent` char(15) NOT NULL DEFAULT 'Asia' REFERENCES ContinentTable(Continent),
  `Region` char(26) NOT NULL DEFAULT '',
  `SurfaceArea` float(10,2) NOT NULL DEFAULT '0.00',
  `IndepYear` smallint(6) DEFAULT NULL,
  `Population` int(11) NOT NULL DEFAULT '0',
  `LifeExpectancy` float(3,1) DEFAULT NULL,
  `GNP` float(10,2) DEFAULT NULL,
  `GNPOld` float(10,2) DEFAULT NULL,
  `LocalName` char(45) NOT NULL DEFAULT '',
  `GovernmentForm` char(45) NOT NULL DEFAULT '',
  `HeadOfState` char(60) DEFAULT NULL,
  `Capital` int(11) DEFAULT NULL,
  `Code2` char(2) NOT NULL DEFAULT ''
);

CREATE TABLE `City` (
  `ID` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
  `Name` char(35) NOT NULL DEFAULT '',
  `CountryCode` char(3) NOT NULL DEFAULT '',
  `District` char(20) NOT NULL DEFAULT '',
  `Population` int(11) NOT NULL DEFAULT '0',
  FOREIGN KEY(CountryCode) REFERENCES Country(`Code`)
);

CREATE TABLE `CountryLanguage` (
  `CountryCode` char(3) NOT NULL DEFAULT '',
  `Language` char(30) NOT NULL DEFAULT '',
  `IsOfficial` char(1) NOT NULL DEFAULT 'F' REFERENCES TrueFalseTable(Value),
  `Percentage` float(4,1) NOT NULL DEFAULT '0.0',
  PRIMARY KEY (`CountryCode`,`Language`),
  FOREIGN KEY (CountryCode) REFERENCES Country(Code)
);
