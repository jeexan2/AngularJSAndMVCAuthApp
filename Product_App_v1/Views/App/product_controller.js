(function () {
    'use strict';

    angular
        .module('app')
        .controller('product_controller', product_controller);

    product_controller.$inject = ['$scope'];

    function product_controller($scope) {
        $scope.title = 'product_controller';
        
        activate();

        function activate() { }
    }
})();
