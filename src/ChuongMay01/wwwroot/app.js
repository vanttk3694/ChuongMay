!function() {
    "use strict";
    angular.module("chuongmay01", [ "ngRoute", "ui.router", "categoryService" ]), angular.module("chuongmay01").config([ "$routeProvider", "$locationProvider", "$stateProvider", "$urlRouterProvider", function(a, b, c, d) {
        c.state("index", {
            url: "/index",
            abstract: !0,
            templateUrl: "partials/category.html"
        }).state("add", {
            url: "/add",
            templateUrl: "admin/indexOld.html"
        }), d.otherwise("/index");
    } ]);
}(), function() {
    "use strict";
    function a(a, b) {
        var c = function() {
            a.categoryList = b.APIData();
        };
        c();
    }
    angular.module("chuongmay01").controller("categoryController", a), a.$inject = [ "$scope", "categoryService" ];
}(), function() {
    "use strict";
    var a = angular.module("categoryService", [ "ngResource" ]);
    a.factory("categoryService", [ "$resource", function(a) {
        return a("/api/category/", {}, {
            APIData: {
                method: "GET",
                params: {},
                isArray: !0
            }
        });
    } ]);
}();
//# sourceMappingURL=app.js.map