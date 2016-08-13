!function() {
    "use strict";
    angular.module("chuongmay01", [ "ngRoute", "ui.router", "categoryViewService", "categoryAddService" ]), 
    angular.module("chuongmay01").config([ "$routeProvider", "$locationProvider", "$stateProvider", "$urlRouterProvider", function(a, b, c, d) {
        c.state("index", {
            url: "/",
            abstract: !0,
            templateUrl: "partials/category.html"
        }).state("category", {
            url: "/category",
            templateUrl: "admin/category/category-view.html",
            controller: "categoryController"
        }).state("category.add", {
            url: "/add",
            templateUrl: "admin/category/category-create.html",
            controller: "categoryAddController"
        }), d.otherwise("/");
    } ]);
}(), function() {
    "use strict";
    function a(a, b) {
        var c = function() {
            a.categoryList = b.APIData();
        };
        c();
    }
    function b(a, b) {
        a.addData = function() {
            var c = {
                CategoryId: 0,
                CategoryName: a.CategoryName,
                CategoryParentId: a.CategoryParentId,
                CategoryUrl: a.CategoryUrl
            };
            console.log(c);
            var d = b.post(c);
            d.then(function(a) {}, function(a) {
                console.log("Err" + a);
            });
        };
    }
    angular.module("chuongmay01").controller("categoryController", a).controller("categoryAddController", b), 
    a.$inject = [ "$scope", "categoryViewService" ], b.$inject = [ "$scope", "categoryAddService" ];
}(), function() {
    "use strict";
    var a = angular.module("categoryViewService", [ "ngResource" ]), b = angular.module("categoryAddService", [ "ngResource" ]);
    a.factory("categoryViewService", [ "$resource", function(a) {
        return a("/api/category/", {}, {
            APIData: {
                method: "GET",
                params: {},
                isArray: !0
            }
        });
    } ]), b.service("categoryAddService", [ "$http", function(a) {
        this.post = function(b) {
            var c = a({
                method: "POST",
                url: "/api/Category",
                data: b
            });
            return c;
        };
    } ]);
}();
//# sourceMappingURL=app.js.map