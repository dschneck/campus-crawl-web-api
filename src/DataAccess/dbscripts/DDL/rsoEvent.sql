CREATE TABLE RsoEvent (
    Id VARCHAR(36) NOT NULL,
    EventId VARCHAR(36) NOT NULL,
    FOREIGN KEY(EventId) REFERENCES Event(attribute)
);
