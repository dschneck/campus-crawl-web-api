CREATE TABLE University (
    Id STRING(36) NOT NULL,
    Name STRING(100) NOT NULL,
    Address STRING(MAX) NOT NULL,
    Description STRING(MAX) NOT NULL,
    NumberOfStudents INT64
) PRIMARY KEY(Id);
