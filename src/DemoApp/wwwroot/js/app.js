'use strict';

var eventsApp = angular.module('eventsApp', ['ngResource', 'ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        
        $routeProvider.when('/newEvent',
        {
            templateUrl: 'templates/NewEvent.html',
            controller: 'EditEventController'
        });
        
        $routeProvider.when('/events', 
        {
            templateUrl: 'templates/EventList.html',
            controller: 'EventListController'
        });
        
        $routeProvider.when('/event/:eventId',
        {
            templateUrl: 'templates/EventDetails.html',
            controller: 'EventController'
        });

        $routeProvider.when('/editProfile',
        {
            templateUrl: 'templates/EditProfile.html',
            controller: 'EditProfileController'
        });

        $routeProvider.when('/sampleDirective',{
            templateUrl: 'templates/SampleDirective.html',
            controller: 'SampleDirectiveController'
        });

        $routeProvider.otherwise({ 
            redirectTo: '/events' 
        });
    }
);
