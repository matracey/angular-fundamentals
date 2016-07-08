'use strict';

eventsApp.filter('durations', function() {
    return function (duration) {
        switch (duration) {
            case 1:
                return "30 mins";
            case 2:
                return "1 hour";
            case 3:
                return "Half day";
            default:
            case 4:
                return "Full day";
        }
    }
});