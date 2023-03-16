# Routes
----------------------------------------------
    /users: to manage user registration and login
        /users/login
            POST
        /users/register
            POST
    /universities: to create and update university profiles
        POST
        PUT
    /rsos: to create, join, and manage RSOs
        GET
        /create
            POST
        /join
            POST
    /events: to create, update, delete, and view events
        /search
            POST
        /eventID
            /comments: to add, remove, and edit comments on events
                /list
                    GET
                /comment
                    POST
                    PUT
                    DELETE
            /ratings: to rate events on a scale of 1-5
                GET
                POST
                PUT
    /social: to integrate with social networks like Facebook or Google
