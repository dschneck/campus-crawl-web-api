CREATE TABLE User (
    Id STRING(36) NOT NULL,
    Email STRING(320) NOT NULL,
    Password STRING(MAX) NOT NULL,
    FirstName STRING(20) NOT NULL,
    LastName STRING(40) NOT NULL,
    UniversityId STRING(36) NOT NULL,
    FOREIGN KEY(UniversityId) REFERENCES University(UniversityId),
) PRIMARY KEY(Id);
