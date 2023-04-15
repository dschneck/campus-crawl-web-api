CREATE TABLE User (
    Id STRING(36) NOT NULL,
    Email STRING(320) NOT NULL,
    Password STRING(MAX) NOT NULL,
    UniversityId STRING(STRING) NOT NULL,
    FOREIGN KEY(UniversityId) REFERENCES University(UniversityId),
    PRIMARY KEY(Id)
);
