CREATE TABLE Event (
    Id STRING(36) NOT NULL,
    AdminId STRING(36) NOT NULL,
    Name STRING(100) NOT NULL,
    Description STRING(MAX) NOT NULL,
    Category STRING(20) NOT NULL,
    StartTime TIMESTAMP NOT NULL,
    EndTime TIMESTAMP NOT NULL,
    LocationId STRING(36)  NOT NULL,
    FOREIGN KEY(LocationId) REFERENCES Location(Id),
    FOREIGN KEY(AdminId) REFERENCES Admin(Id)
) PRIMARY KEY(Id);

CREATE UNIQUE NULL_FILTERED INDEX TimeAndSpaceConstraint ON Event (StartTime, LocationId);
