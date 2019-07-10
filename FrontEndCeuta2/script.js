const RESOURCE_NAME = 'https://localhost:44368/api/values';

const app = new Vue({
    el: '#app',
    data: {
        name: '',
        dep: '',
        person: '',
        ip: ''
    },
    methods:{
        crearVisita() {
            axios.get(`${RESOURCE_NAME}/${this.name}&${this.dep}&${this.person}&${this.ip}&`)
            .then(response => console.log(response.data), )
        }
    }
});

Vue.component('modal', {
    template: '#modal-template'
  })
  
  // start app
  new Vue({
    el: '#app',
    data: {
      showModal: false
    }
  })