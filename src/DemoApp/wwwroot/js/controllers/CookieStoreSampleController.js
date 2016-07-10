'use strict';

eventsApp.controller('CookieStoreSampleController',
    function CookieStoreSampleController($scope, $cookieStore, $log) {
        $scope.event = {
            id: 1,
            name: "My Event"
        };

        $scope.saveEventToCookie = function (event) {
            $cookieStore.put('event', event);
        };

        $scope.getEventFromCookie = function () {
            $log.log($cookieStore.get('event'));
        };

        $scope.removeEventCookie = function () {
            $cookieStore.remove('event');
        }
    }
);