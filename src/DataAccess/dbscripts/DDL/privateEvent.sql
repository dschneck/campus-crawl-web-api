CREATE TABLE PrivateEvent (
    Id STRING(36) NOT NULL,
    EventId STRING(36) NOT NULL,
    UniversityId STRING(36) NOT NULL,
    FOREIGN KEY(UniversityId) REFERENCES University(Id),
    FOREIGN KEY(EventId) REFERENCES Event(Id)
) PRIMARY KEY(Id);
