(function ($) {

    var formValidator;
    var form = $('#user-form');

    form.submit(function () {
        if (!validateDOB()) {

            formValidator = form.validate({});

            formValidator.showErrors({
                'DOBDay': ' ',
                'DOBMonth': ' ',
                'DOBYear': ' '
            });

            return false;
        }
    });

    validateDOB = function () {
        var dobDay = $('#DOBDay').val();
        var dobMonth = $('#DOBMonth').val();
        var dobYear = $('#DOBYear').val();

        if (dobDay.length > 0 && dobMonth.length > 0 && dobYear.length > 0) {
            
            if (!moment(dobDay + '/' + dobMonth + '/' + dobYear, 'DD/MM/YYYY').isValid()) {
                return false;
            }

            var dobDate = moment([dobYear, dobMonth - 1, dobDay]);
            var minDate = moment([moment().year() - 18, moment().month(), moment().date()]);

            return dobDate <= minDate;
        }

        return true;
    }

    jQuery.validator.addMethod('checkDOB', function (value, element, params) {
        return validateDOB();
    }, '');

    jQuery.validator.addMethod('over18Years', function (value, element, params) {
        return validateDOB();
    }, '');

    jQuery.validator.unobtrusive.adapters.add('dob', {}, function (options) {
        options.rules['over18Years'] = true;
        options.messages['over18Years'] = options.message;
    });

    jQuery.validator.unobtrusive.adapters.add('dobfield', {}, function (options) {
        options.rules['checkDOB'] = true;
        options.messages['checkDOB'] = options.message;
    });

})(jQuery);