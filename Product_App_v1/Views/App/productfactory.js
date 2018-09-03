(function () {
    'use strict';

    angular
        .module('app')
        .factory('productfactory', productfactory);

    productfactory.$inject = ['$http'];

    function productfactory($http) {
        var service = {
            getData: getData
        };

        return service;

        function getData() { }
    }
})();