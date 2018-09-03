(function () {
    'use strict';

    angular
        .module('app')
        .directive('productdirective', productdirective);

    productdirective.$inject = ['$window'];

    function productdirective($window) {
        // Usage:
        //     <productdirective></productdirective>
        // Creates:
        // 
        var directive = {
            link: link,
            restrict: 'EA'
        };
        return directive;

        function link(scope, element, attrs) {
        }
    }

})();