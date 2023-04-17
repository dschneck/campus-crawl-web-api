CREATE TABLE PublicEvent (
    Id STRING(36) NOT NULL,
    EventId STRING(36) NOT NULL
    FOREIGN KEY(EventId) REFERENCES Event(attribute)
);
