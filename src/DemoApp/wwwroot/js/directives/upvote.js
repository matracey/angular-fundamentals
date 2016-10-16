'use strict';

eventsApp.directive('upvote', function () {
    return {
        restrict: 'E',
        templateUrl: 'templates/directives/Upvote.html',
        scope: {
            upvote: "&", // & = execute in parent scope
            downvote: "&",
            count: "="
        }
    };
});