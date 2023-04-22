CREATE TABLE Member (
    Id STRING(36) NOT NULL,
    UserId STRING(36) NOT NULL,
    RsoId STRING(36) NOT NULL,
    FOREIGN KEY(RsoId) REFERENCES RSO(Id),
    FOREIGN KEY(UserId) REFERENCES User(Id)
) PRIMARY KEY(UserId, RsoId);
