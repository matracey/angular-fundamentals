'use strict';

eventsApp.factory('myCache', function myCache($cacheFactory, $log) {
    return $cacheFactory('myCache', {capacity: 3});
});