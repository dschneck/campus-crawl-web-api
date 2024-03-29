CREATE TABLE RSO (
    Id STRING(36) NOT NULL,
    UniversityId STRING(36) NOT NULL,
    Status STRING(10) NOT NULL,
    Description STRING(100) NOT,
    Name STRING(20) NOT NULL,
    FOREIGN KEY(UniversityId) REFERENCES University(Id)
) PRIMARY KEY(Id);
