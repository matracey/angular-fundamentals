'use strict';

eventsApp.directive('mySample', function ($compile) {
    return {
        restict: 'E',
        replace: true,
        template: "<input type='text' ng-model='sampleData' /> {{sampleData}} <br />",
        scope: {
            
        }
    };
})