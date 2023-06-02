var app = angular.module('ticketSystemapp', [
    'ui.router',
    'kendo.directives',
]);

app.config(function ($stateProvider, $urlRouterProvider, $locationProvider) {
    $stateProvider
        .state('tickets', {
            url: '/ticketsbro',
            templateUrl: "App/components/tickets/tickets.html",
            controller: "ticketsController"
        });
});
