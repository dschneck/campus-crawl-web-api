CREATE TABLE University (
    UniversityId STRING(36) NOT NULL,
    Address STRING(MAX) NOT NULL,
    Description STRING(MAX) NOT NULL,
    NumberOfStudents INT,
    PRIMARY KEY(UniversityId)
);
