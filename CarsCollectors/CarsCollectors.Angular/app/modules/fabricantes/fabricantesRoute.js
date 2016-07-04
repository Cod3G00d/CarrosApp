'use strict';

/**
 * @ngdoc function
 * @name app.route:fabricantesRoute
 * @description
 * # fabricantesRoute
 * Route of the app
 */

angular.module('fabricantes')
	.config(['$stateProvider', function ($stateProvider) {
		
		$stateProvider
			.state('home.fabricantes', {
				url:'/fabricantes',
				templateUrl: 'app/modules/fabricantes/fabricantes.html',
				controller: 'FabricantesCtrl',
				controllerAs: 'vm'
			});

		
	}]);
