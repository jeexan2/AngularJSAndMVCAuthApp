(function () {
    'use strict';

    angular.module('app', [
        // Angular modules 
        'ngRoute'

        // Custom modules 

        // 3rd Party Modules

    ]).controller('product_controller', function ($scope, $http) {
        $scope.initData = function () {
            $http.get('/Home/ProductList') // added an '/' along with deleting Controller portion
                .then(function (response) {
                    $scope.data = response.data;
                });
        }        
})();