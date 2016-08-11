(function () {
    'use strict';

    angular
        .module('chuongmay01')
        .controller('categoryController', categoryController);

    categoryController.$inject = ['$scope', 'categoryService'];

    function categoryController($scope, categoryService) {
        var getData = function () {
            $scope.categoryList = categoryService.APIData();
        }
        getData();

        /*$scope.category = new Category();
        $scope.category.CategoryId = 0;
        var addData = function () {
            if ($scope.category.CategoryParentId == null) {
                $scope.category.CategoryParentId = 0;
            }
            else if ($scope.category.CategoryParentId != null) {
                $scope.category.CategoryUrl = Util.convertToURL($scope.category.CategoryName);
                $scope.category.CategoryParentId = categoryService.attributes[2].value;
                Category.save($scope.category, function () {
                    getData();
                    $scope.category.CategoryParentId = categoryService.attributes[2].value;
                    $mdDialog.hide("Insert thanh cong!!");

                    Util.simpleToast("Bạn đã thêm thành công danh mục " + $scope.category.CategoryName);
                });
            }
        }*/
    }
})();
