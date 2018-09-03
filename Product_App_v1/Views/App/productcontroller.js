(function () {
    'use strict';

    angular
        .module('app')
        .controller('productcontroller', productcontroller);

    productcontroller.$inject = ['$location'];

    function productcontroller($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'productcontroller';

        activate();

        function activate() { }
    }
})();
