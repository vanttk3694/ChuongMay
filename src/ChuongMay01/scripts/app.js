(function () {
    'use strict';

    angular.module('chuongmay01', [
        // Angular modules 
        'ngRoute',
        'ui.router',
        // Custom modules 
        "categoryViewService",
        "categoryAddService"
        // 3rd Party Modules

    ]);

    angular.module('chuongmay01').config(['$routeProvider', '$locationProvider', '$stateProvider', '$urlRouterProvider',
        function ($routeProvider, $locationProvider, $stateProvider, $urlRouterProvider) {
            $stateProvider
                    //CLIENT
                        .state('index', {
                            url: '/',
                            abstract: true,
                            templateUrl: 'partials/category.html'
                        })
                        .state('category', {
                            url: '/category',
                            templateUrl: 'admin/category/category-view.html',
                            controller: 'categoryController'
                        })
                        .state('category.add', {
                            url: '/add',
                            templateUrl: 'admin/category/category-create.html',
                            controller: 'categoryAddController'
                        });

            /* $routeProvider
                .when('/', {
                    templateUrl: 'partials/quotes.html',
                    controller: 'quotesController'
                })
                .when('/quotes/add', {
                    templateUrl: 'partials/add.html',
                    controller: 'quotesAddcontroller'
                });*/
            $urlRouterProvider.otherwise('/');
            /*$locationProvider.html5Mode({
                enabled: true,
                requireBase: false
            });*/
        }
    ]);
})();