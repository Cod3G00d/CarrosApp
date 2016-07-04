'use strict';

/**
 * @ngdoc function
 * @name app.route:veiculosRoute
 * @description
 * # veiculosRoute
 * Route of the app
 */

angular.module('veiculos')
	.config(['$stateProvider', function ($stateProvider) {
		
		$stateProvider
			.state('home.veiculos', {
				url:'/veiculos',
				templateUrl: 'app/modules/veiculos/veiculos.html',
				controller: 'VeiculosCtrl',
				controllerAs: 'vm'
			});

		
	}]);
