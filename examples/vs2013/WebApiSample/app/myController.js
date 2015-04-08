(function () {
    'use strict';

    angular
        .module('app')
        .controller('MyController', MyController);

    MyController.$inject = ['$modal', 'userRepository', '$window'];

    function MyController($modal, userRepository, $window) {
        /* jshint validthis:true */
        var vm = this;

        function activate() {
            userRepository
                .getAll()
                .then(getAllUsersComplete, getAllUsersFailed);
        }

        function getAllUsersComplete(response) {
            vm.users = response.data;
        }

        function getAllUsersFailed() {
            console.log('An error has occurred!');
        }

        activate();

        vm.userSelected = function() {
            $window.alert('A user has been selected.  Do something about it :)');
        };
    }
})();