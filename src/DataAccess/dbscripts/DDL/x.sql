CREATE TABLE Admin (Id STRING(36) NOT NULL, MemberId STRING(36) NOT NULL, FOREIGN KEY(MemberId) REFERENCES Member(Id)) PRIMARY KEY(Id);

CREATE TABLE Event (
    Id STRING(36) NOT NULL,
    LocationId STRING(36)  NOT NULL,
    RsoId STRING(36) NOT NULL,
    Name STRING(100) NOT NULL,
    Description STRING(MAX) NOT NULL,
    Category STRING(20) NOT NULL,
    StartTime TIMESTAMP NOT NULL,
    EndTime TIMESTAMP NOT NULL,
    FOREIGN KEY(LocationId) REFERENCES Location(Id),
    FOREIGN KEY(RsoId) REFERENCES RSO(Id)
) PRIMARY KEY(Id);

CREATE TABLE PrivateEvent (
    Id STRING(36) NOT NULL,
    EventId STRING(36) NOT NULL,
    UniversityId STRING(36) NOT NULL,
    FOREIGN KEY(UniversityId) REFERENCES University(Id),
    FOREIGN KEY(EventId) REFERENCES Event(Id)
) PRIMARY KEY(Id);

CREATE TABLE RsoEvent (
    Id STRING(36) NOT NULL,
    EventId STRING(36) NOT NULL,
    RSOId STRING(36) NOT NULL,
    FOREIGN KEY(EventId) REFERENCES Event(Id),
    FOREIGN KEY(RSOId) REFERENCES RSO(Id)
) PRIMARY KEY(Id);

CREATE TABLE PublicEvent (
    Id STRING(36) NOT NULL,
    EventId STRING(36) NOT NULL,
    FOREIGN KEY(EventId) REFERENCES Event(Id)
) PRIMARY KEY(Id);
