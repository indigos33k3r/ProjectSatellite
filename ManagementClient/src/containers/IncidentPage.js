import React from 'react';
import PropTypes from 'prop-types';
import TabHeader from '../components/TabHeader';
import IncidentList from '../components/IncidentList';

export class IncidentPage extends React.Component {
  render() {
    const SubTabs = ['Current', 'Past', 'New'];
    return (
      <div>
        <TabHeader Prefix="Incidents" Headers={SubTabs} />
        <IncidentList View={this.props.match.params.View} />
      </div>
    );
  }
}

IncidentPage.propTypes = {
  match: PropTypes.objectOf(PropTypes.string).isRequired
};

export default IncidentPage;
