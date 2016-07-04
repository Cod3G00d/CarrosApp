(function () {
	'use strict';

	/**
	 * @ngdoc function
	 * @name app.test:veiculosTest
	 * @description
	 * # veiculosTest
	 * Test of the app
	 */

	describe('veiculos test', function () {
		var controller = null, $scope = null;

		beforeEach(function () {
			module('carscollectors');
		});

		beforeEach(inject(function ($controller, $rootScope) {
			$scope = $rootScope.$new();
			controller = $controller('VeiculosCtrl', {
				$scope: $scope
			});
		}));

		it('Should controller must be defined', function () {
			expect(controller).toBeDefined();
		});

	});
})();
