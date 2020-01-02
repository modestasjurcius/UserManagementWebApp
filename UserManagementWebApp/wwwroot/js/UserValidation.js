$("#userDataForm").validate({
    rules: {
        Username: {
            required: true,
            maxlength: 30,
            minlength: 3
        },
        Password: {
            required: true,
            maxlength: 30,
            minlength: 6
        },
        PasswordConfirm: {
            equalTo: Password
        },
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
        Username: {
            required: "Username is required",
            maxlength: "Too long",
            minlength: "Too short"
        },
        Password: {
            required: "Password is required",
            maxlength: "Too long",
            minlength: "Too short"
        },
        PasswordConfirm: {
            equalTo: "Passwords do not match"
        },
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
    },
    errorElement: "div",
    wrapper: "div",
    errorPlacement: function (error, element) {
        offset = element.offset();
        error.insertAfter(element);
        error.addClass('customError');
    }
});