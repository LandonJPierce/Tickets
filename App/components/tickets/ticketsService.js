app.service('ticketsService', ['$http', function ($http) {
    this.getData = function () {
        return $http.get('/api/Ticket');
    };
}]);