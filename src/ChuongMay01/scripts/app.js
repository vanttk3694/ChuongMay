(function () {
    'use strict';

    angular.module('chuongmay01', [
        // Angular modules 
        'ngRoute',
        'ui.router',
        // Custom modules 
        "categoryService"

        // 3rd Party Modules

    ]);

    angular.module('chuongmay01').config(['$routeProvider', '$locationProvider', '$stateProvider', '$urlRouterProvider',
        function ($routeProvider, $locationProvider, $stateProvider, $urlRouterProvider) {
            $stateProvider
                    //CLIENT
                        .state('index', {
                            url: '/index',
                            abstract: true,
                            templateUrl: 'partials/category.html'
                        })
                        .state('add', {
                            url: '/add',
                            templateUrl: 'admin/indexOld.html'
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
            $urlRouterProvider.otherwise('/index');
            /*$locationProvider.html5Mode({
                enabled: true,
                requireBase: false
            });*/
        }
    ]);
})();