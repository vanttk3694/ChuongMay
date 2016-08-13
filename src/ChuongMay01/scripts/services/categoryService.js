(function () {
    'use strict';

    var categoryViewService = angular.module('categoryViewService', ['ngResource']);
    var categoryAddService = angular.module('categoryAddService', ['ngResource'])

    categoryViewService.factory('categoryViewService', ['$resource',
        function ($resource) {
            return $resource('/api/category/', {}, {

                APIData: { method: 'GET', params: {}, isArray: true }
            });
        }]);

    categoryAddService.service('categoryAddService', ['$http',
        function($http){
            this.post = function (Category) {
                var request = $http({
                    method: "POST",
                    url: "/api/Category",
                    data: Category
                });
                return request;
            }
    }]);

    /*categoryService.factory('categoryFactory', [
        function () {
            var attributes = [
            {
                name: 'CategoryName',
                title: 'Tên',
                value: '',
                minlength: 1,
                maxlength: 255
            },
            {
                name: 'CategoryParentId',
                title: 'Danh mục cha',
                value: '',
                isParent: 0,
                minlength: 1,
                maxlength: 255
            },
            {
                name: 'CategoryUrl',
                title: 'Đường dẫn',
                value: '',
                minlength: 0,
                maxlength: 5
            }

        ];
        return categoryFactory;
        }
    ]);*/
})();