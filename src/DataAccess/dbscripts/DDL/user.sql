CREATE TABLE User (
    Id VARCHAR(36) NOT NULL,
    Email VARCHAR(320) NOT NULL,
    Password TEXT NOT NULL,
    UniversityId VARCHAR(36) NOT NULL,
    FOREIGN KEY(UniversityId) REFERENCES University(UniversityId),
    PRIMARY KEY(Id)
);
