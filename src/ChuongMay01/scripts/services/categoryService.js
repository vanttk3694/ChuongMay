(function () {
    'use strict';

    var categoryService = angular.module('categoryService', ['ngResource']);

    categoryService.factory('categoryService', ['$resource',
        function ($resource) {
            return $resource('/api/category/', {}, {

                APIData: { method: 'GET', params: {}, isArray: true }
            });
        }]);
})();