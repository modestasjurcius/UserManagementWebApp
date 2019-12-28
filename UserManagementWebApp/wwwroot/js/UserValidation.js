$("#userDataForm").validate({
    rules: {
        FirstName: {
            required: true,
            maxlength: 30,
            minlength: 3
        },
        LastName: {
            required: true,
            maxlength: 30,
            minlength: 3
        },
        BirthDate: {
            required: true
        },
        Description: {
            maxlength: 255
        }
    },
    messages: {
        FirstName: {
            required: "First name is required",
            maxlength: "Too long",
            minlength: "Too short"
        },
        LastName: {
            required: "Last name is required",
            maxlength: "Too long",
            minlength: "Too short"
        },
        BirthDate: {
            required: "Birth date is required"
        },
        Description: {
            maxlength: "Description is too long! Maximum length is 255 characters"
        }
    }
});