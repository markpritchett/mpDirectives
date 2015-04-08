(function () {
    'use strict';

    angular
        .module('app')
        .factory('userRepository', userRepository);

    userRepository.$inject = ['$http'];

    function userRepository($http) {
        var service = {
            getAll: getAll
        };

        return service;

        function getAll() {
            return $http.get('api/users');
        }
    }
})();