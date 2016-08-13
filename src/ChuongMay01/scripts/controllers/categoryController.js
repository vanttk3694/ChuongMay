(function () {
    'use strict';

    angular
        .module('chuongmay01')
        .controller('categoryController', categoryController)
        .controller('categoryAddController', categoryAddController);

    categoryController.$inject = ['$scope', 'categoryViewService'];
    function categoryController($scope, categoryViewService) {
        var getData = function () {
            $scope.categoryList = categoryViewService.APIData();
        }
        getData();        
    }

    categoryAddController.$inject = ['$scope', 'categoryAddService'];
    function categoryAddController($scope, categoryAddService) {        
        $scope.addData = function () {
            var Category = {
                CategoryId: 0,
                CategoryName: $scope.CategoryName,
                CategoryParentId: $scope.CategoryParentId,
                CategoryUrl: $scope.CategoryUrl,
            };
            console.log(Category);
            var promisePost = categoryAddService.post(Category);
            promisePost.then(function (pl) {
            }, function (err) {
                console.log("Err" + err);
            });
        }
    }

    /*categoryEditController.$inject = ['$scope', 'categoryEditService'];
    function categoryAddController($scope, categoryEditService) {
        $scope.editData = function () {
            var Category = {
                CategoryId: 0,
                CategoryName: $scope.CategoryName,
                CategoryParentId: $scope.CategoryParentId,
                CategoryUrl: $scope.CategoryUrl,
            };
            console.log(Category);
            var promisePut = categoryEditService.put($scope.CategoryId, Category);
            promisePut.then(function (pl) {
                $scope.Message = "Updated Successfuly";
            }, function (err) {
                console.log("Err" + err);
            });
        }
    }*/
    
})();
