CREATE TABLE Admin (
    Id STRING(36) NOT NULL,
    UserId STRING(36) NOT NULL,
    FOREIGN KEY(UserId) REFERENCES Users(Id),
) PRIMARY KEY(Id);