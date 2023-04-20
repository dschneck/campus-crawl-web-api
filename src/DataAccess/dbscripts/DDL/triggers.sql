CREATE TRIGGER UpdateRSOStatus_MemberJoined
    AFTER INSERT ON Member
    REFERENCING NEW AS NewMember
    WHEN ((SELECT COUNT(*)
           FROM Member M
           WHERE M.RSOId = NewMember.RSOId) > 4)
    FOR EACH ROW /* Row-level trigger */
BEGIN
    UPDATE RSO /* Action */
    SET Status = 'active'
    WHERE Id = NewMember.RSOId;
END;

CREATE TRIGGER UpdateRSOStatus_MemberLeft
    AFTER DELETE ON Member
    REFERENCING OLD AS ExMember
    WHEN ((SELECT COUNT(*)
    FROM Member M
    WHERE M.RSOId = ExMember.RSOId) < 5)
    FOR EACH ROW
BEGIN
    UPDATE RSO
    SET Status = 'inactive'
    WHERE Id = ExMember.RSOId
END;
