angular.module('ticketSystemapp').controller('ticketsController', ['ticketsService', function ($scope, ticketsService) {
    $scope.mainGridOptions = {
        dataSource: {
            transport: {
                read: function (e) {
                    newFormService.getData().then(function (response) {
                        e.success(response.data);  // this will pass the data to the Grid
                    }, function (error) {
                        e.error(error);
                    });
                }
            },
            schema: {
                model: {
                    fields: {
                        Id: { type: 'number' },
                        Title: { type: 'string' },
                        Due: { type: 'string' },
                        Priority: { type: 'string' },
                        Status: { type: 'string' },
                        AffectedUser: { type: 'string' },
                        Owner: { type: 'string' },
                        Score: { type: 'string' }
                    }
                }
            }
        },
        columns: [
            {
                field: "Id",
                title: "Ticket Number",
                width: "120px"
            },
            {
                field: "Title",
                title: "Title",
                width: "120px"
            },
            {
                field: "Due",
                title: "Due",
                width: "120px"
            },
            {
                field: "Priority",
                title: "Status",
                width: "120px"
            },
            {
                field: "Status",
                title: "Status",
                width: "120px"
            },
            {
                field: "AffectedUser",
                title: "AffectedUser",
                width: "120px"
            },
            {
                field: "Owner",
                title: "Owner",
                width: "120px"
            },
            {
                field: "Score",
                title: "Score",
                width: "120px"
            }
        ],
        sortable: true,
        pageable: true
    };
}])