CREATE TABLE SuperAdmin (
    Id STRING(36) NOT NULL,
    UID STRING(36) NOT NULL,
    FOREIGN KEY(UID) REFERENCES User(Id)
) PRIMARY KEY(Id);
